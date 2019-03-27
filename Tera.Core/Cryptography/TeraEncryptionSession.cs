using Tera.Core.Network;

namespace Tera.Core.Cryptography
{
    public sealed class TeraEncryptionSession
    {
        #region Constants
        public const int KEY_SIZE = 128;
        #endregion
        #region [PUBLIC]Fields
        public readonly PacketDirection Direction;
        public readonly TeraEncryptionKeys Keys;
        #endregion
        #region Fields
        private TeraEncryptionKeys _keys;
        private readonly TeraEncryption _decryptor, _encryptor;
        #endregion
        #region [PUBLIC]Methods
        public TeraEncryptionSession(PacketDirection direction, TeraEncryptionKeys keys)
        {
            Direction = direction;
            _keys = keys;
            _keys.DecryptKey = XorKey(ShiftKey(keys.ClientKey2, 29, false), XorKey(ShiftKey(keys.ServerKey1, 67, true), keys.ClientKey1));
            _decryptor = new TeraEncryption(keys.DecryptKey);
            byte[] tempKey = ShiftKey(keys.ServerKey2, 41, true);
            _decryptor.Apply(tempKey, 0, tempKey.Length);
            keys.EncryptKey = tempKey;
            _encryptor = new TeraEncryption(keys.EncryptKey);
        }
        #endregion
        #region [PUBLIC]Methods
        public void Decrypt(byte[] data, int offset, int length) => (Direction == PacketDirection.ServerToClient ? _decryptor : _encryptor).Apply(data, offset, length);
        public void Encrypt(byte[] data, int offset, int length) => (Direction == PacketDirection.ServerToClient ? _encryptor : _decryptor).Apply(data, offset, length);
        #endregion
        #region [PRIVATE\STATIC]Methods
        private static byte[] XorKey(byte[] key1, byte[] key2)
        {
            byte[] result = new byte[key1.Length];
            for (int i = 0; i < result.Length; i++) result[i] = (byte)(key1[i] ^ key2[i]);
            return result;
        }
        private static byte[] ShiftKey(byte[] key, int shift, bool direction)
        {
            byte[] result = new byte[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                if (direction) result[(i + shift) % key.Length] = key[i]; else result[i] = key[(i + shift) % key.Length];
            }
            return result;
        }
        #endregion
    }
}