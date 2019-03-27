using Tera.Core.Cryptography;
using Tera.Core.Network;
using System;
using System.Linq;
using Tera.Core.Network.Protocol;
using TeraxHook.GUI.Tabs;
using TeraxHook.GUI.Forms;
using Tera.Core.Internals;

namespace TeraxHook.Internals
{
    public enum PacketControllerStatus : byte { Online, Offline, Waiting }
    public static class PacketController
    {
        #region [PUBLIC]Fields
        public static GameClient Client;
        #endregion
        #region [PRIVATE]Fields
        private static DllMain Main;
        private static PacketControllerStatus serverStatus = PacketControllerStatus.Offline;
        #endregion
        #region [PUBLIC]Properties
        public static PacketControllerStatus Status { get => serverStatus; private set { serverStatus = value; StatusChanged?.Invoke(value); } }
        #endregion
        #region [PUBLIC]Internals
        public static void Finish()
        {
            Status = PacketControllerStatus.Offline;
        }
        public static void Preinitialize(DllMain main, byte[] data)
        {
            Globals.RefreshData();
            if (!data.SequenceEqual(new byte[] { 1, 0, 0, 0 })) throw new ArgumentException("Failed to compare magic bytes.");
            Main = main;
            Status = PacketControllerStatus.Waiting;
        }
        public static void Initialize(byte[] clientKey1, byte[] clientKey2, byte[] serverKey1, byte[] serverKey2)
        {
            Client = new GameClient(new TeraEncryptionKeys(clientKey1, clientKey2, serverKey1, serverKey2), Globals.Tables);
            TabPackets.AddTable(Client.Processor.Serializer.Tables.Game);
            Client.PacketReceived += (packet) => TabPackets.AddPacket(packet);
            Status = PacketControllerStatus.Online;
        }
        #endregion
        #region [PRIVATE]Methods
        public static int ProcessClientData(byte[] data) => Main.SendToServer(Client.ProcessData(data, PacketDirection.ClientToServer));
        public static byte[] ProcessServerData(byte[] data) => Client.ProcessData(data, PacketDirection.ServerToClient);
        public static void Send(Packet packet) => Send(Client.Processor.Serializer.Serialize(packet));
        public static void Send(RawPacket packet) => Send(Client.Encrypt(packet), packet.Direction);
        public static void Send(byte[] data, PacketDirection direction)
        {
            switch (direction)
            {
                case PacketDirection.ClientToServer: Main.SendToServer(data); break;
                case PacketDirection.ServerToClient: Main.RData = data; break;
            }
        }
        #endregion
        #region Events
        public static event Action<PacketControllerStatus> StatusChanged;
        #endregion
    }
}