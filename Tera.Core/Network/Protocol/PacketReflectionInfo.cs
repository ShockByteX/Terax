using System;
using System.Reflection;

namespace Tera.Core.Network.Protocol
{
    public class PacketReflectionInfo
    {
        #region Fields
        public readonly Type Type;
        public readonly FieldInfo[] Fields;
        #endregion
        #region Constructors
        public PacketReflectionInfo(Type type, FieldInfo[] fields) { Type = type; Fields = fields; }
        #endregion
        #region [PUBLIC]Overrides
        public override string ToString() => Type.Name;
        #endregion
    }
}