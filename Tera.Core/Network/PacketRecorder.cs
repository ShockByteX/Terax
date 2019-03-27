using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tera.Core.Network
{
    public class PacketRecorder
    {
        #region Fields
        [JsonProperty("packets")]
        public List<EncryptedPacket> Packets;
        [JsonProperty("ck1")]
        public byte[] ClientKey1;
        [JsonProperty("ck2")]
        public byte[] ClientKey2;
        [JsonProperty("sk1")]
        public byte[] ServerKey1;
        [JsonProperty("sk2")]
        public byte[] ServerKey2;
        #endregion
        #region Constructors
        public PacketRecorder(byte[] clientKey1, byte[] clientKey2, byte[] serverKey1, byte[] serverKey2)
        {
            ClientKey1 = clientKey1;
            ClientKey2 = clientKey2;
            ServerKey1 = serverKey1;
            ServerKey2 = serverKey2;
            Packets = new List<EncryptedPacket>();
        }
        #endregion
    }
}