﻿using System;
using System.Runtime.InteropServices;

namespace Tera.Core.Marshaling
{
    public static class LocalUnmanagedMemory
    {
        #region [PUBLIC]Methods
        public static byte[] StructureToBytes<T>(T obj, int size)
        {
            IntPtr address = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, address, false);
            byte[] buffer = new byte[size];
            Marshal.Copy(address, buffer, 0, size);
            Marshal.FreeHGlobal(address);
            return buffer;
        }
        public static T BytesToStructure<T>(byte[] data, int size)
        {
            IntPtr address = Marshal.AllocHGlobal(size);
            Marshal.Copy(data, 0, address, size);
            T obj = (T)Marshal.PtrToStructure(address, typeof(T));
            Marshal.FreeHGlobal(address);
            return obj;
        }
        public static byte[] StructureToBytes(object obj, int size)
        {
            IntPtr address = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, address, false);
            byte[] buffer = new byte[size];
            Marshal.Copy(address, buffer, 0, size);
            Marshal.FreeHGlobal(address);
            return buffer;
        }
        public static object BytesToStructure(byte[] data, int size, Type type)
        {
            IntPtr address = Marshal.AllocHGlobal(size);
            Marshal.Copy(data, 0, address, size);
            object obj = Marshal.PtrToStructure(address, type);
            Marshal.FreeHGlobal(address);
            return obj;
        }
        #endregion
    }
}