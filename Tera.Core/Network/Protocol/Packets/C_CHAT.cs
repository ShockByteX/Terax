using Tera.Core.Game;

namespace Tera.Core.Network.Protocol.Packets
{
    public sealed class C_CHAT : Packet
    {
        #region Fields
        public ushort TextOffset;
        public ChatChannel Channel;
        public string Message;
        #endregion
        #region Constructors
        public C_CHAT() : base(nameof(C_CHAT)) { }
        #endregion
    }
}