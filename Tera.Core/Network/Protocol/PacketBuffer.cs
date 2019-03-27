using System;

namespace Tera.Core.Network.Protocol
{
    public class PacketBuffer
    {
        #region Constants
        public const int BUFFER_CAPACITY = ushort.MaxValue * 4;
        #endregion
        #region [PUBLIC]Fields
        public readonly PacketDirection Direction;
        #endregion
        #region Fields
        private byte[] _encBuffer = new byte[BUFFER_CAPACITY], _decBuffer = new byte[BUFFER_CAPACITY];
        private int _encBufferLength, _decBufferLength;
        #endregion
        #region Constructors
        public PacketBuffer(PacketDirection direction) { Direction = direction; }
        #endregion
        #region [PUBLIC]Methods
        public RawPacket ReadPacket()
        {
            int packetLength = BitConverter.ToUInt16(_decBuffer, 0);
            if (packetLength == 0) return null;
            if (_decBufferLength < packetLength) return null;
            byte[] data = new byte[packetLength];
            Array.Copy(_decBuffer, 0, data, 0, data.Length);
            RawPacket packet = new RawPacket(data, Direction);
            RemoveBuffer(ref _decBuffer, ref _decBufferLength, packetLength);
            return packet;
        }
        public byte[] ReadData()
        {
            byte[] data = new byte[_encBufferLength];
            Array.Copy(_encBuffer, 0, data, 0, data.Length);
            RemoveBuffer(ref _encBuffer, ref _encBufferLength, data.Length);
            return data;
        }
        public void WriteData(byte[] data) => WriteBuffer(data, ref _decBuffer, ref _decBufferLength);
        public void WritePacket(RawPacket packet) => WriteBuffer(packet.Data, ref _encBuffer, ref _encBufferLength);
        #endregion
        #region [PRIVATE]Methods
        private static void RemoveBuffer(ref byte[] buffer, ref int bufferLength, int count)
        {
            int newLength = bufferLength - count;
            Array.Copy(buffer, count, buffer, 0, newLength);
            for (int i = newLength; i < bufferLength; i++) buffer[i] = 0;
            bufferLength = newLength;
        }
        private static void WriteBuffer(byte[] data, ref byte[] buffer, ref int bufferLength)
        {
            Array.Copy(data, 0, buffer, bufferLength, data.Length);
            bufferLength += data.Length;
        }
        #endregion
    }
}