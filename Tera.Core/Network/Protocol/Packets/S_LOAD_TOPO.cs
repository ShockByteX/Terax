using System.Numerics;

namespace Tera.Core.Network.Protocol.Packets
{
    public sealed class S_LOAD_TOPO : Packet
    {
        #region Fields
        public uint Zone;
        public Vector3 Location;
        public bool Quick;
        #endregion
        #region Constructors
        public S_LOAD_TOPO() : base(nameof(S_LOAD_TOPO)) { }
        #endregion
    }
}