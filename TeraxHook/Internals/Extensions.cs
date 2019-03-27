using System;
using System.Runtime.InteropServices;

namespace TeraxHook.Internals
{
    public static class Extensions
    {
        public static byte[] ExtractBuffer(this IntPtr ptrBuffer, int length)
        {
            byte[] data = new byte[length];
            Marshal.Copy(ptrBuffer, data, 0, length);
            return data;
        }
    }
}