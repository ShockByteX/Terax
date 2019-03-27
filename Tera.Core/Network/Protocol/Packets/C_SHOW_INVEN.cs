namespace Tera.Core.Network.Protocol.Packets
{
    public sealed class C_SHOW_INVEN : Packet
    {
        #region Fields
        public uint Unknown1;
        #endregion
        #region Constructors
        public C_SHOW_INVEN() : base(nameof(C_SHOW_INVEN)) { }
        #endregion
    }
}