using System;
using System.Linq;

namespace Tera.Core.Cryptography
{
    internal sealed class TeraEncryption
    {
        #region Fields
        private readonly TeraEncryptionKey[] _keys = new TeraEncryptionKey[3] { new TeraEncryptionKey(55, 31), new TeraEncryptionKey(57, 50), new TeraEncryptionKey(58, 39) };
        private int _changeData;
        private int _changeLength;
        #endregion
        #region Constructors
        public TeraEncryption(byte[] key) { GenerateKey(key); }
        #endregion
        #region [PUBLIC]Methods
        public void Apply(byte[] data, int offset, int length)
        {
            int pre = (length < _changeLength) ? length : _changeLength;
            if (pre != 0)
            {
                for (int j = 0; j < pre; j++) data[offset + j] ^= (byte)(_changeData >> 8 * (4 - _changeLength + j));
                _changeLength -= pre;
            }
            for (int k = pre; k < length - 3; k += 4)
            {
                DoRound();
                TeraEncryptionKey[] keys = _keys;
                foreach (TeraEncryptionKey key in keys)
                {
                    data[offset + k] ^= (byte)key.Sum;
                    data[offset + k + 1] ^= (byte)(key.Sum >> 8);
                    data[offset + k + 2] ^= (byte)(key.Sum >> 16);
                    data[offset + k + 3] ^= (byte)(key.Sum >> 24);
                }
            }
            int remain = length - pre & 3;
            if (remain != 0)
            {
                DoRound();
                _changeData = 0;
                TeraEncryptionKey[] keys2 = _keys;
                foreach (TeraEncryptionKey key2 in keys2) _changeData ^= (int)key2.Sum;
                for (int i = 0; i < remain; i++) data[offset + length - remain + i] ^= (byte)(_changeData >> i * 8);
                _changeLength = 4 - remain;
            }
        }
        #endregion
        #region [PRIVATE]Methods
        private void GenerateKey(byte[] key)
        {
            byte[] buffer = new byte[_keys.Aggregate(0, (int acc, TeraEncryptionKey x) => acc + x.Size) * 4];
            buffer[0] = 128;
            for (int j = 1; j < buffer.Length; j++) buffer[j] = key[j % 128];
            for (int l = 0; l < buffer.Length; l += 20)
            {
                uint[] sha = TeraEncryptionHash.ComputeHash(buffer);
                for (int i = 0; i < sha.Length; i++) Buffer.BlockCopy(BitConverter.GetBytes(sha[i]), 0, buffer, l + i * 4, 4);
            }
            for (int n = 0; n < _keys[0].Buffer.Length; n += 4) _keys[0].Buffer[n / 4] = BitConverter.ToUInt32(buffer, n);
            for (int m = 0; m < _keys[1].Buffer.Length; m += 4) _keys[1].Buffer[m / 4] = BitConverter.ToUInt32(buffer, 220 + m);
            for (int k = 0; k < _keys[2].Buffer.Length; k += 4) _keys[2].Buffer[k / 4] = BitConverter.ToUInt32(buffer, 448 + k);
        }
        private void DoRound()
        {
            int result = (_keys[0].Key & _keys[1].Key) | (_keys[2].Key & (_keys[0].Key | _keys[1].Key));
            for (int i = 0; i < _keys.Length; i++)
            {
                TeraEncryptionKey key = _keys[i];
                if (result == key.Key)
                {
                    uint t5 = key.Buffer[key.Position1];
                    uint t4 = key.Buffer[key.Position2];
                    uint t3 = (t5 <= t4) ? t5 : t4;
                    key.Sum = t5 + t4;
                    key.Key = ((t3 > key.Sum) ? 1 : 0);
                    key.Position1 = (key.Position1 + 1) % key.Size;
                    key.Position2 = (key.Position2 + 1) % key.Size;
                }
            }
        }
        #endregion
        #region [NESTED]Classes
        private sealed class TeraEncryptionKey
        {
            #region Fields
            public int Size;
            public uint[] Buffer;
            public int Key;
            public int Position1;
            public int Position2;
            public uint Sum;
            #endregion
            #region Constructors
            public TeraEncryptionKey(int size, int position2) { Size = size; Buffer = new uint[size * 4]; Position2 = position2; }
            #endregion
        }
        #endregion
    }
}