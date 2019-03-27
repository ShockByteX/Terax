namespace Tera.Core.Cryptography
{
    internal static class TeraEncryptionHash
    {
        #region Constants
        public const int HASH_SIZE = 20;
        #endregion
        #region [PUBLIC]Methods
        public static uint[] ComputeHash(byte[] data)
        {
            TeraSHA1 sha = new TeraSHA1();
            sha.Update(data);
            return sha.Hash();
        }
        #endregion
        #region [NESTED]Classes
        private sealed class TeraSHA1
        {
            #region Constants
            private const int BLOCK_SIZE = 64;
            #endregion
            #region Fields
            private bool _computed;
            private ulong _lengthHigh, _lengthLow;
            private int _blockIndex;
            private readonly byte[] _messageBlock = new byte[64];
            private readonly uint[] _messageDigest = new uint[5] { 1732584193u, 4023233417u, 2562383102u, 271733878u, 3285377520u };
            #endregion
            #region [PUBLIC]Methods
            public void Update(byte[] data)
            {
                foreach (byte b in data)
                {
                    _messageBlock[_blockIndex++] = b;
                    _lengthLow += 8uL;
                    if (_lengthLow == 0) _lengthHigh += 1uL;
                    if (_blockIndex == 64) ProcessMessageBlock();
                }
            }
            public uint[] Hash()
            {
                if (!_computed) { PadMessage(); _computed = true; }
                return _messageDigest;
            }
            #endregion
            #region [PRIVATE]Methods
            private void PadMessage()
            {
                _messageBlock[_blockIndex++] = 128;
                if (_blockIndex > 56)
                {
                    while (_blockIndex < 64) _messageBlock[_blockIndex++] = 0;
                    ProcessMessageBlock();
                }
                while (_blockIndex < 56) _messageBlock[_blockIndex++] = 0;
                _messageBlock[56] = (byte)(_lengthHigh >> 24);
                _messageBlock[57] = (byte)(_lengthHigh >> 16);
                _messageBlock[58] = (byte)(_lengthHigh >> 8);
                _messageBlock[59] = (byte)_lengthHigh;
                _messageBlock[60] = (byte)(_lengthLow >> 24);
                _messageBlock[61] = (byte)(_lengthLow >> 16);
                _messageBlock[62] = (byte)(_lengthLow >> 8);
                _messageBlock[63] = (byte)_lengthLow;
                ProcessMessageBlock();
            }
            private void ProcessMessageBlock()
            {
                uint[] w = new uint[80];
                for (int t = 0; t < 16; t++) w[t] = (uint)(_messageBlock[t * 4] << 24 | _messageBlock[t * 4 + 1] << 16 | _messageBlock[t * 4 + 2] << 8 | _messageBlock[t * 4 + 3]);
                for (int t2 = 16; t2 < 80; t2++) w[t2] = (w[t2 - 3] ^ w[t2 - 8] ^ w[t2 - 14] ^ w[t2 - 16]);
                uint a = _messageDigest[0];
                uint b = _messageDigest[1];
                uint c = _messageDigest[2];
                uint d = _messageDigest[3];
                uint e = _messageDigest[4];
                for (int t3 = 0; t3 < 80; t3++)
                {
                    uint temp = RotateLeft(a, 5) + e + w[t3];
                    if (t3 < 20) temp += ((b & c) | (~b & d)) + 1518500249;
                    else if (t3 < 40) temp += (b ^ c ^ d) + 1859775393;
                    else if (t3 < 60) temp = (uint)((int)temp + ((int)((b & c) | (b & d) | (c & d)) + -1894007588));
                    else if (t3 < 80) temp = (uint)((int)temp + ((int)(b ^ c ^ d) + -899497514));
                    e = d;
                    d = c;
                    c = RotateLeft(b, 30);
                    b = a;
                    a = temp;
                }
                _messageDigest[0] += a;
                _messageDigest[1] += b;
                _messageDigest[2] += c;
                _messageDigest[3] += d;
                _messageDigest[4] += e;
                _blockIndex = 0;
            }
            #endregion
            #region [PRIVATE\STATIC]Methods
            private static uint RotateLeft(uint word, int bits) => word << bits | word >> 32 - bits;
            #endregion
        }
        #endregion
    }
}