using System;

namespace Tera.Core.Network.Protocol
{
    public delegate bool RawPacketHandler(GameClient client, PacketDirection direction, RawPacket packet);
    public sealed class RawPacket
    {
        #region Constants
        public const ushort HEADER_SIZE = 4;
        public const ushort MAX_PACKET_SIZE = ushort.MaxValue;
        public const ushort MAX_PAYLOAD_SIZE = MAX_PACKET_SIZE - HEADER_SIZE;
        #endregion
        #region Fields
        public readonly byte[] Data;
        public readonly ushort Length, OpCode;
        public readonly PacketDirection Direction;
        public readonly DateTime Time;
        #endregion
        #region Constructors
        public RawPacket(byte[] data, PacketDirection direction)
        {
            Data = data;
            Length = (ushort)(Data[0] | Data[1] << 8);
            OpCode = (ushort)(Data[2] | Data[3] << 8);
            Direction = direction;
            Time = DateTime.UtcNow;
        }
        #endregion
        #region [PUBLIC]Methods
        public byte[] GetPayloadData()
        {
            byte[] buffer = new byte[Length - 4];
            Array.Copy(Data, 4, buffer, 0, buffer.Length);
            return buffer;
        }
        public byte[] GetHeaderData()
        {
            byte[] buffer = new byte[HEADER_SIZE];
            Array.Copy(Data, 0, buffer, 0, HEADER_SIZE);
            return buffer;
        }
        #endregion
    }
}