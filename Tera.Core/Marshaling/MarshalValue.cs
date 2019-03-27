using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Tera.Core.Marshaling
{
    public class MarshalValue
    {
        #region Fields
        public readonly Type RealType;
        public int Size;
        public readonly TypeCode TypeCode;
        #endregion
        #region Constructors
        public MarshalValue(Type type)
        {
            if (type.IsEnum) type = type.GetEnumUnderlyingType();
            RealType = type;
            TypeCode = Type.GetTypeCode(RealType);
            switch (TypeCode)
            {
                case TypeCode.Boolean: Size = 1; break;
                case TypeCode.String: Size = 0; break;
                default: Size = Marshal.SizeOf(RealType); break;
            }
        }
        #endregion
        #region [PUBLIC]Methods
        #endregion
        public byte[] ObjectToByteArray(object obj)
        {
            switch (TypeCode)
            {
                case TypeCode.Boolean: return BitConverter.GetBytes((bool)obj);
                case TypeCode.Char: return Encoding.UTF8.GetBytes(new[] { (char)obj });
                case TypeCode.Double: return BitConverter.GetBytes((double)obj);
                case TypeCode.Int16: return BitConverter.GetBytes((short)obj);
                case TypeCode.UInt16: return BitConverter.GetBytes((ushort)obj);
                case TypeCode.Int32: return BitConverter.GetBytes((int)obj);
                case TypeCode.UInt32: return BitConverter.GetBytes((uint)obj);
                case TypeCode.Int64: return BitConverter.GetBytes((long)obj);
                case TypeCode.UInt64: return BitConverter.GetBytes((ulong)obj);
                case TypeCode.Single: return BitConverter.GetBytes((float)obj);
                case TypeCode.String: throw new InvalidCastException("This method doesn't support string conversion.");
            }
            return LocalUnmanagedMemory.StructureToBytes(obj, Size);
        }
        public object ByteArrayToObject(byte[] data)
        {
            switch (TypeCode)
            {
                case TypeCode.Boolean: return BitConverter.ToBoolean(data, 0);
                case TypeCode.Byte: return data[0];
                case TypeCode.Char: return Encoding.UTF8.GetChars(data)[0]; //BitConverter.ToChar(byteArray, 0);
                case TypeCode.Double: return BitConverter.ToDouble(data, 0);
                case TypeCode.Int16: return BitConverter.ToInt16(data, 0);
                case TypeCode.Int32: return BitConverter.ToInt32(data, 0);
                case TypeCode.Int64: return BitConverter.ToInt64(data, 0);
                case TypeCode.Single: return BitConverter.ToSingle(data, 0);
                case TypeCode.String: return Encoding.Unicode.GetString(data);
                case TypeCode.UInt16: return BitConverter.ToUInt16(data, 0);
                case TypeCode.UInt32: return BitConverter.ToUInt32(data, 0);
                case TypeCode.UInt64: return BitConverter.ToUInt64(data, 0);
            }
            return LocalUnmanagedMemory.BytesToStructure(data, Size, RealType);
        }
    }
}