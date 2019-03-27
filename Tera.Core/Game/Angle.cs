using System;

namespace Tera.Core.Game
{
    public struct Angle : IEquatable<Angle>, IComparable<Angle>
    {
        #region Fields
        public readonly short Raw;
        public double Radians => Raw * 2 * Math.PI / (ushort.MaxValue + 1);
        public double Degrees => Raw * 360.0 / (ushort.MaxValue + 1);
        #endregion
        #region Constructors
        public Angle(short raw) { Raw = raw; }
        #endregion
        #region [PUBLIC]Methods
        public bool Equals(Angle other) => Raw == other.Raw;
        public int CompareTo(Angle other) => Raw.CompareTo(other.Raw);
        #endregion
        #region [PUBLIC]Overrides
        public override bool Equals(object obj) => obj is Angle a ? Equals(a) : false;
        public override int GetHashCode() => Raw.GetHashCode();
        public override string ToString() => $"[Raw: {Raw}, Radians: {Radians}, Degrees: {Degrees}]";
        #endregion
        #region [STATIC]Methods
        public static Angle FromRadians(double value) => new Angle((short)(value / (2 * Math.PI) * (ushort.MaxValue + 1)));
        public static Angle FromDegrees(double value) => new Angle((short)(value / 360 * (ushort.MaxValue + 1)));
        #endregion
        #region [STATIC]Operators
        public static bool operator ==(Angle a, Angle b) => a.Equals(b);
        public static bool operator !=(Angle a, Angle b) => !a.Equals(b);
        public static bool operator >(Angle a, Angle b) => a.CompareTo(b) > 0;
        public static bool operator <(Angle a, Angle b) => a.CompareTo(b) < 0;
        public static bool operator >=(Angle a, Angle b) => a.CompareTo(b) >= 0;
        public static bool operator <=(Angle a, Angle b) => a.CompareTo(b) <= 0;
        #endregion
    }
}