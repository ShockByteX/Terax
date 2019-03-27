using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Tera.Core.Network
{
    public class EncryptedPacket
    {
        #region Fields
        [JsonProperty("data")]
        public byte[] Data;
        [JsonProperty("direction")]
        public PacketDirection Direction;
        [JsonProperty("time"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Time;
        #endregion
        #region Constructors
        public EncryptedPacket(byte[] data, PacketDirection direction) { Data = data; Direction = direction; Time = DateTime.UtcNow; }
        #endregion
    }
}