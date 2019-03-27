using System.Numerics;
using Tera.Core.Game;

namespace Tera.Core.Network.Protocol.Packets
{
    public sealed class C_PLAYER_LOCATION : Packet
    {
        #region Fields
        public Vector3 Position;
        public Angle Direction;
        public ushort Unknown1;
        public Vector3 Destination;
        public MovementKind Kind;
        public ushort Speed;
        public byte Unknown2;
        public uint Timestamp;
        #endregion
        #region Constructors
        public C_PLAYER_LOCATION() : base(nameof(C_PLAYER_LOCATION)) { }
        #endregion
    }
}