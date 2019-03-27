using Newtonsoft.Json;
using Tera.Core.Network;
using System;
using System.IO;

namespace Test.Internals
{
    public static class PacketReceiver
    {
        #region Fields
        private static PacketRecorder _recorder = JsonConvert.DeserializeObject<PacketRecorder>(File.ReadAllText("D:\\encrypted.json"));
        #endregion
        #region Properties
        public static byte[] ClientKey1 => _recorder.ClientKey1;
        public static byte[] ClientKey2 => _recorder.ClientKey2;
        public static byte[] ServerKey1 => _recorder.ServerKey1;
        public static byte[] ServerKey2 => _recorder.ServerKey2;
        #endregion
        #region [PUBLIC]Methods
        public static void Start()
        {
            int length = _recorder.Packets.Count;
            for (int i = 0; i < length; i++) PacketReceived?.Invoke(_recorder.Packets[i]);
        }
        #endregion
        #region Events
        public static event Action<EncryptedPacket> PacketReceived;
        #endregion
    }
}