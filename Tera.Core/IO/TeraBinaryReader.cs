using System;
using System.IO;
using System.Numerics;
using System.Text;
using Tera.Core.Game;

namespace Tera.Core.IO
{
    public class TeraBinaryReader : IDisposable
    {
        #region [PUBLIC]Fields
        public static readonly Encoding Encoding = Encoding.Unicode;
        #endregion
        #region Fields
        private BinaryReader _reader;
        private bool _disposed;
        #endregion
        #region Constructors\Destructors
        public TeraBinaryReader(byte[] data) : this(new MemoryStream(data, false), false) { }
        public TeraBinaryReader(Stream stream) : this(stream, false) { }
        public TeraBinaryReader(Stream stream, bool leaveOpen) => _reader = new BinaryReader(stream, Encoding, leaveOpen);
        ~TeraBinaryReader() => Dispose();
        #endregion
        #region [PUBLIC]Operations
        public string ReadString(Type type)
        {
            if (type.IsEnum)
            {
                Type uType = type.GetEnumUnderlyingType();
                TypeCode typeCode = Type.GetTypeCode(uType);
                switch (typeCode)
                {
                    case TypeCode.SByte: return Enum.GetName(type, _reader.ReadSByte());
                    case TypeCode.Byte: return Enum.GetName(type, _reader.ReadByte());
                    case TypeCode.Int16: return Enum.GetName(type, _reader.ReadInt16());
                    case TypeCode.UInt16: return Enum.GetName(type, _reader.ReadUInt16());
                    case TypeCode.Int32: return Enum.GetName(type, _reader.ReadInt32());
                    case TypeCode.UInt32: return Enum.GetName(type, _reader.ReadUInt32());
                    case TypeCode.Int64: return Enum.GetName(type, _reader.ReadInt64());
                    case TypeCode.UInt64: return Enum.GetName(type, _reader.ReadUInt64());
                    default: throw new Exception("Enum underlying type is not supprted");
                }
            }
            else
            {
                TypeCode typeCode = Type.GetTypeCode(type);
                switch (typeCode)
                {
                    case TypeCode.Object:
                        if (type == typeof(Vector3)) return new Vector3(_reader.ReadSingle(), _reader.ReadSingle(), _reader.ReadSingle()).ToString();
                        if (type == typeof(Angle)) return new Angle(_reader.ReadInt16()).ToString();
                        break;
                    case TypeCode.Boolean: return _reader.ReadBoolean().ToString();
                    case TypeCode.Char: return _reader.ReadChar().ToString();
                    case TypeCode.SByte: return _reader.ReadSByte().ToString();
                    case TypeCode.Byte: return _reader.ReadByte().ToString();
                    case TypeCode.Int16: return _reader.ReadInt16().ToString();
                    case TypeCode.UInt16: return _reader.ReadUInt16().ToString();
                    case TypeCode.Int32: return _reader.ReadInt32().ToString();
                    case TypeCode.UInt32: return _reader.ReadUInt32().ToString();
                    case TypeCode.Int64: return _reader.ReadInt64().ToString();
                    case TypeCode.UInt64: return _reader.ReadUInt64().ToString();
                    case TypeCode.Single: return _reader.ReadSingle().ToString();
                    case TypeCode.Double: return _reader.ReadDouble().ToString();
                    case TypeCode.DateTime: throw new Exception("Is going to be supported.");
                    case TypeCode.String:
                        string result = null;
                        char c;
                        while ((c = _reader.ReadChar()) != 0) result += c;
                        return result;
                }
                throw new Exception("Not supported");
            }
        }
        public object Read(Type type)
        {
            type = type.IsEnum ? type.GetEnumUnderlyingType() : type;
            TypeCode typeCode = Type.GetTypeCode(type);
            switch (typeCode)
            {
                case TypeCode.Object:
                    if (type == typeof(Vector3)) return new Vector3(_reader.ReadSingle(), _reader.ReadSingle(), _reader.ReadSingle());
                    if (type == typeof(Angle)) return new Angle(_reader.ReadInt16());
                    break;
                case TypeCode.Boolean: return _reader.ReadBoolean();
                case TypeCode.Char: return _reader.ReadChar();
                case TypeCode.SByte: return _reader.ReadSByte();
                case TypeCode.Byte: return _reader.ReadByte();
                case TypeCode.Int16: return _reader.ReadInt16();
                case TypeCode.UInt16: return _reader.ReadUInt16();
                case TypeCode.Int32: return _reader.ReadInt32();
                case TypeCode.UInt32: return _reader.ReadUInt32();
                case TypeCode.Int64: return _reader.ReadInt64();
                case TypeCode.UInt64: return _reader.ReadUInt64();
                case TypeCode.Single: return _reader.ReadSingle();
                case TypeCode.Double: return _reader.ReadDouble();
                case TypeCode.DateTime: throw new Exception("Is going to be supported.");
                case TypeCode.String:
                    string result = null;
                    char c;
                    while ((c = _reader.ReadChar()) != 0) result += c;
                    return result;
            }
            throw new Exception("Not supported");
        }
        #endregion
        #region [PUBLIC]Methods
        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            _reader.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}