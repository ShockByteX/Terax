using System;
using System.Runtime.InteropServices;

namespace TeraxHook.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WSABuffer { public int Length; public IntPtr Buffer; }
}