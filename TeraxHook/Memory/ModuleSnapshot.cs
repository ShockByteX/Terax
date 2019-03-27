using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using TeraxHook.Helpers;

namespace TeraxHook.Memory
{
    public class ModuleSnapshot : IDisposable
    {
        #region Fields
        private IntPtr _address;
        private byte[] _buffer;
        private int _length;
        private bool _disposed;
        #endregion
        #region Properties
        public IntPtr Address => _address;
        #endregion
        #region Constructors
        public ModuleSnapshot(ProcessModule module)
        {
            _address = module.BaseAddress;
            _length = module.ModuleMemorySize;
            _buffer = new byte[_length];
            Marshal.Copy(module.BaseAddress, _buffer, 0, _length);
        }
        #endregion
        #region [PUBLIC]Operations
        public IEnumerable<int> FindOffset(params byte?[][] patterns)
        {
            bool IsMatch(byte?[] pattern, int offset)
            {
                for (var i = 0; i < pattern.Length; i++)
                {
                    byte? b = pattern[i];
                    if (b != null && _buffer[offset + i] != b) return false;
                }
                return true;
            }
            return (from i in Enumerable.Range(0, _length) from p in patterns where i + p.Length < _length where IsMatch(p, i) select i).Distinct();
        }
        public long FindPattern(string strPattern, int patternOffset, int addressOffset, bool read, bool subtract)
        {
            byte[] pattern = ParseHelper.BytesFromPattern(strPattern, out byte dByte);
            for (long i = 0; i < _length; i++)
            {
                if (_buffer[i] == pattern[0])
                {
                    if (CheckMask(ref pattern, dByte, i))
                    {
                        i += patternOffset + _address.ToInt64();
                        if (read) i = LocalMemory.Read<IntPtr>((IntPtr)i).ToInt64();
                        if (subtract) i -= _address.ToInt64();
                        return i + addressOffset;
                    }
                }
            }
            return 0;
        }
        #endregion
        #region [PUBLIC]Methods
        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            _buffer = null;
            _length = 0;
        }
        #endregion
        #region [PRIVATE]Methods
        private bool CheckMask(ref byte[] pattern, byte dByte, long offset)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                byte cByte = pattern[i];
                if (cByte != dByte && cByte != _buffer[i + offset]) return false;
            }
            return true;
        }
        #endregion
    }
}