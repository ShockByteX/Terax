using System;
using System.IO;
using System.Numerics;
using System.Text;
using Tera.Core.Game;
using Tera.Core.Marshaling;
using Tera.Core.Network.Protocol;

namespace Tera.Core.IO
{
    public class TeraBinaryWriter : IDisposable
    {
        #region [PUBLIC]Fields
        public static readonly Encoding Encoding = Encoding.Unicode;
        #endregion
        #region Fields
        private BinaryWriter _writer;
        private bool _disposed;
        #endregion
        #region Proprties
        public int Position { get => (int)_writer.BaseStream.Position; set => _writer.BaseStream.Position = value; }
        public Stream Stream => _writer.BaseStream;
        public int Length => (int)_writer.BaseStream.Length;
        public bool EndOfStream => Position == Length;
        #endregion
        #region Constructors
        public TeraBinaryWriter() : this(new MemoryStream(RawPacket.MAX_PAYLOAD_SIZE), false) { }
        public TeraBinaryWriter(byte[] buffer) : this(new MemoryStream(buffer), false) { }
        public TeraBinaryWriter(Stream stream, bool leaveOpen) => _writer = new BinaryWriter(stream, Encoding, leaveOpen);
        ~TeraBinaryWriter() => Dispose();
        #endregion
        #region [PUBLIC]Operations
        public void Write(ushort value) => _writer.Write(value);
        public void Write(Type type, object obj)
        {
            type = type.IsEnum ? type.GetEnumUnderlyingType() : type;
            TypeCode typeCode = Type.GetTypeCode(type);
            switch (typeCode)
            {
                case TypeCode.Object: _writer.Write(new MarshalValue(type).ObjectToByteArray(obj)); break;
                case TypeCode.Boolean: _writer.Write((bool)obj); break;
                case TypeCode.Char: _writer.Write((char)obj); break;
                case TypeCode.SByte: _writer.Write((sbyte)obj); break;
                case TypeCode.Byte: _writer.Write((byte)obj); break;
                case TypeCode.Int16: _writer.Write((short)obj); break;
                case TypeCode.UInt16: _writer.Write((ushort)obj); break;
                case TypeCode.Int32: _writer.Write((int)obj); break;
                case TypeCode.UInt32: _writer.Write((uint)obj); break;
                case TypeCode.Int64: _writer.Write((long)obj); break;
                case TypeCode.UInt64: _writer.Write((ulong)obj); break;
                case TypeCode.Single: _writer.Write((float)obj); break;
                case TypeCode.Double: _writer.Write((double)obj); break;
                case TypeCode.DateTime: throw new Exception("Is going to be supported.");
                case TypeCode.String: _writer.Write($"{(string)obj}\0".ToCharArray()); break;
                default: throw new Exception("Not supported");
            }
        }
        #endregion
        #region [PUBLIC]Methods
        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            _writer.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}