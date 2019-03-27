using System;

namespace Tera.Core.Cryptography
{
    public class TeraEncryptionKeys
    {
        #region Constants
        public const int KEY_SIZE = 128;
        #endregion
        #region Fields
        internal readonly byte[] ClientKey1, ClientKey2, ServerKey1, ServerKey2;
        internal byte[] DecryptKey, EncryptKey;
        #endregion
        #region Constructors
        public TeraEncryptionKeys(byte[] clientKey1, byte[] clientKey2, byte[] serverKey1, byte[] serverKey2)
        {
            ValidateKey(clientKey1, nameof(clientKey1));
            ValidateKey(clientKey2, nameof(clientKey2));
            ValidateKey(serverKey1, nameof(serverKey1));
            ValidateKey(serverKey2, nameof(serverKey2));
            ClientKey1 = clientKey1;
            ClientKey2 = clientKey2;
            ServerKey1 = serverKey1;
            ServerKey2 = serverKey2;
        }
        #endregion
        #region [PRIVATE\STATIC]Methods
        private static void ValidateKey(byte[] key, string argName)
        {
            if (key == null) throw new ArgumentNullException(nameof(argName), "The encryption key can't be null.");
            if (key.Length != KEY_SIZE) throw new ArgumentException("Invalid encryption key length.", nameof(argName));
        }
        #endregion
    }
}