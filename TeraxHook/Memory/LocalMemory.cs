using System;
using System.Runtime.InteropServices;
using System.Text;

namespace TeraxHook.Memory
{
    public static class LocalMemory
    {
        #region [PUBLIC]Operations
        public static byte[] Read(IntPtr address, int length)
        {
            byte[] buffer = new byte[length];
            unsafe
            {
                byte* ptrBuffer = (byte*)address;
                for (int i = 0; i < length; i++) buffer[i] = ptrBuffer[i];
            }
            return buffer;
        }
        public static T Read<T>(IntPtr address) => address.Read<T>();
        public static T[] Read<T>(IntPtr address, int length)
        {
            T[] buffer = new T[length];
            for (int i = 0; i < buffer.Length; i++) buffer[i] = Read<T>(address);
            return buffer;
        }
        public static string Read(IntPtr address, Encoding encoding, int maxLength = 256) => encoding.GetString(Read(address, maxLength)).Replace("\0", null);
        public static void Write(IntPtr address, byte[] data)
        {
            unsafe
            {
                byte* ptrBuffer = (byte*)address;
                for (int i = 0; i < data.Length; i++) ptrBuffer[i] = data[i];
            }
        }
        public static void Write<T>(IntPtr address, T value, bool replace = false) => Marshal.StructureToPtr(value, address, replace);
        public static void Write<T>(IntPtr address, T[] values) { foreach (T value in values) Write(address, value, false); }
        public static void Write(IntPtr address, string text, Encoding encoding) => Write(address, encoding.GetBytes(text += text[text.Length - 1] != '\0' ? "\0" : null));
        #endregion
    }
}