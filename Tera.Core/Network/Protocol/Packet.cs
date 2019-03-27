namespace Tera.Core.Network.Protocol
{
    public delegate bool PacketHandler<T>(GameClient client, PacketDirection direction, T packet);
    public abstract class Packet
    {
        #region Fields
        public readonly string OpCode;
        #endregion
        #region Constructors
        internal Packet(string opCode) { OpCode = opCode; }
        #endregion
    }
}