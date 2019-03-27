using EasyHook;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Tera.Core.Internals;
using Tera.Core.Network;
using TeraxHook.GUI.Forms;
using TeraxHook.Internals;
using TeraxHook.Memory;
using TeraxHook.Native;

namespace TeraxHook
{
    public class DllMain : IEntryPoint
    {
        #region Constants
        private static readonly byte[] magicBytes = new byte[] { 1, 0, 0, 0 };
        #endregion
        #region [PUBLIC]Fields
        public byte[] RData;
        #endregion
        #region Fields        
        private IntPtr _socket = IntPtr.Zero;
        private int _serverPackets, _clientPackets;
        private byte[] cKey1, cKey2, sKey1, sKey2;
        #endregion
        #region Constructors
        public DllMain(RemoteHooking.IContext context, string channelName) { }
        #endregion
        #region [PUBLIC]Methods
        [STAThread]
        public unsafe void Run(RemoteHooking.IContext context, string channelName)
        {
            HooksController.InstallHook(LocalHook.Create(LocalHook.GetProcAddress("ws2_32.dll", "WSARecv"), new Ws2_32.WSARecv_Delegate(WSARecv_Hook), this));
            HooksController.InstallHook(LocalHook.Create(LocalHook.GetProcAddress("ws2_32.dll", "send"), new Ws2_32.send_Delegate(send_Hook), this));
            HooksController.InstallHook(LocalHook.Create(LocalHook.GetProcAddress("ws2_32.dll", "connect"), new Ws2_32.connect_Delegate(connect_Hook), this));
            HooksController.InstallHook(LocalHook.Create(LocalHook.GetProcAddress("ws2_32.dll", "closesocket"), new Ws2_32.closesocket_Delegate(closesocket_Hook), this));
            RemoteHooking.WakeUpProcess();
            Application.Run(MainForm.Instance);
            HooksController.RemoveAllHooks();
            LocalHook.Release();
        }
        #endregion
        #region [PUBLIC]Methods
        public unsafe int SendToServer(byte[] buffer, bool junk = true)
        {
            Ws2_32.send_Delegate send = LocalHook.GetProcAddress("ws2_32.dll", "send").ToDelegate<Ws2_32.send_Delegate>();
            fixed (byte* uBuffer = buffer) return send(_socket, (IntPtr)uBuffer, buffer.Length, 0);
        }
        public unsafe int SendToClient(byte[] data, out int length)
        {
            Ws2_32.WSARecv_Delegate recv = LocalHook.GetProcAddress("ws2_32.dll", "WSARecv").ToDelegate<Ws2_32.WSARecv_Delegate>();
            byte[] buffer = new byte[ushort.MaxValue];
            fixed (byte* uBuffer = buffer)
            {
                for (int i = 0; i < data.Length; i++) buffer[i] = data[i];
                WSABuffer wsa = new WSABuffer() { Buffer = (IntPtr)uBuffer, Length = buffer.Length };
                Log.WriteLine($"WSALength: {wsa.Length}, WSABuffer: {wsa.Buffer.ToInt32()}, Transferred: {data.Length}");
                int socketFlags = 0;
                length = data.Length;
                return recv(_socket, ref wsa, 1, out length, ref socketFlags, IntPtr.Zero, IntPtr.Zero);
            }
        }
        public unsafe int SendToServer(byte[] buffer) { fixed (byte* uBuffer = buffer) return Ws2_32.send(_socket, (IntPtr)uBuffer, buffer.Length, 0); }
        #endregion
        #region Hooks
        private unsafe int WSARecv_Hook(IntPtr socket, ref WSABuffer buffer, int bufferCount, out int bytesTransferred, ref int socketFlags, IntPtr nativeOverlapped, IntPtr completionRoutine)
        {
            int result = Ws2_32.WSARecv(socket, ref buffer, bufferCount, out bytesTransferred, ref socketFlags, nativeOverlapped, completionRoutine);
            if (_socket == socket)
            {
                if (bytesTransferred > ushort.MaxValue || bytesTransferred == 0 || bufferCount != 1) return result;
                _serverPackets++;
                byte[] data = buffer.Buffer.ExtractBuffer(bytesTransferred);
                switch (_serverPackets)
                {
                    case 1: PacketController.Preinitialize(this, data); break;
                    case 2: sKey1 = data; break;
                    case 3: sKey2 = data; PacketController.Initialize(cKey1, cKey2, sKey1, sKey2); break;
                    default:
                        byte[] processed = PacketController.ProcessServerData(data);
                        if (processed.Take(4).SequenceEqual(GameClient.C_SIGNATURE))
                        {
                            Marshal.Copy(processed, 4, buffer.Buffer + bytesTransferred, processed.Length - 4);
                            bytesTransferred += processed.Length - 4;
                        }
                        break;
                }
            }
            return 0;
        }
        private unsafe int send_Hook(IntPtr socket, IntPtr buffer, int length, int flags)
        {
            if (_socket == socket)
            {
                if (length > ushort.MaxValue || length == 0) return Ws2_32.send(socket, buffer, length, flags);
                _clientPackets++;
                byte[] data = buffer.ExtractBuffer(length);
                switch (_clientPackets)
                {
                    case 1: cKey1 = data; break;
                    case 2: cKey2 = data; break;
                    default: return PacketController.ProcessClientData(data);
                }
                return Ws2_32.send(socket, buffer, length, flags);
            }
            return Ws2_32.send(socket, buffer, length, flags);
        }
        private unsafe int connect_Hook(IntPtr socket, ref IntPtr sockaddr, int addressLength)
        {
            if (_socket == IntPtr.Zero) _socket = socket;
            return Ws2_32.connect(socket, ref sockaddr, addressLength);
        }
        private unsafe int closesocket_Hook(IntPtr socket)
        {
            if (socket == _socket)
            {
                _socket = IntPtr.Zero;
                _clientPackets = 0;
                _serverPackets = 0;
                PacketController.Finish();
            }
            return Ws2_32.closesocket(socket);
        }
        #endregion
    }
}