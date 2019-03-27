using System;
using System.Runtime.InteropServices;

namespace TeraxHook.Native
{
    public static unsafe class Ws2_32
    {
        #region Structures

        #endregion
        #region Methods
        //[DllImport("ws2_32.dll", CallingConvention = CallingConvention.StdCall)]
        //public unsafe static extern int WSARecv(IntPtr socket, WSABuffer* buffers, int bufferCount, out int bytesTransferred, ref int socketFlags, NativeOverlapped* nativeOverlapped, IntPtr completionRoutine);
        [DllImport("ws2_32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSARecv([In] IntPtr socket, [In] ref WSABuffer buffer, [In] int bufferCount, [Out] out int bytesTransferred, [In, Out] ref int socketFlags, [In]IntPtr overlapped, [In]IntPtr completionRoutine);
        [DllImport("ws2_32.dll", CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern int recv(IntPtr socket, IntPtr buffer, int length, int flags);
        [DllImport("ws2_32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int send(IntPtr socket, IntPtr buffer, int length, int flags);
        [DllImport("Ws2_32.dll")]
        public static extern int connect(IntPtr socket, ref IntPtr sockaddr, int addrsize);
        [DllImport("Ws2_32.dll")]
        public static extern int closesocket(IntPtr socket);
        #endregion
        #region Delegates
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public unsafe delegate int WSARecv_Delegate(IntPtr socket, ref WSABuffer buffer, int bufferCount, out int bytesTransferred, ref int socketFlags, IntPtr overlapped, IntPtr completionRoutine);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int send_Delegate(IntPtr socket, IntPtr buffer, int length, int flags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int connect_Delegate(IntPtr socket, ref IntPtr sockaddr, int addressLength);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int closesocket_Delegate(IntPtr socket);
        #endregion
    }
}