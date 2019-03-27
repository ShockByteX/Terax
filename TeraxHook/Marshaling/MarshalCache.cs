using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TeraxHook.Marshaling
{
    public static class MarshalCache<T>
    {
        #region Fields
        public unsafe delegate void* GetUnsafePtrDelegate(ref T value);
        public static readonly GetUnsafePtrDelegate GetUnsafePtr;
        public static int Size;
        public static Type RealType;
        public static TypeCode TypeCode;
        public static bool TypeRequiresMarshal;
        #endregion
        #region Constructors
        static MarshalCache()
        {
            Type type = typeof(T);
            TypeCode = Type.GetTypeCode(type);
            if (type == typeof(bool)) { Size = 1; RealType = type; }
            else if (type.IsEnum)
            {
                Type underlying = type.GetEnumUnderlyingType();
                Size = GetSizeOf(underlying);
                RealType = underlying;
                TypeCode = Type.GetTypeCode(underlying);
            }
            else { Size = GetSizeOf(type); RealType = type; }
            TypeRequiresMarshal = RequiresMarshal(RealType);
            DynamicMethod method = new DynamicMethod($"GetPinnedPtr<{typeof(T).FullName.Replace(".", "<>")}>", typeof(void*), new[] { typeof(T).MakeByRefType() }, typeof(MarshalCache<>).Module);
            ILGenerator generator = method.GetILGenerator();
            generator.Emit(OpCodes.Ldarg_0);
            generator.Emit(OpCodes.Conv_U);
            generator.Emit(OpCodes.Ret);
            GetUnsafePtr = (GetUnsafePtrDelegate)method.CreateDelegate(typeof(GetUnsafePtrDelegate));
        }
        #endregion
        #region [PRIVATE]Methods
        private static int GetSizeOf(Type t)
        {
            try { return Marshal.SizeOf(t); }
            catch
            {
                int totalSize = 0;
                foreach (FieldInfo field in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    object[] attr = field.GetCustomAttributes(typeof(FixedBufferAttribute), false);
                    if (attr.Length > 0)
                    {
                        FixedBufferAttribute fba = attr[0] as FixedBufferAttribute;
                        totalSize += GetSizeOf(fba.ElementType) * fba.Length;
                    }
                    totalSize += GetSizeOf(field.FieldType);
                }
                return totalSize;
            }
        }
        private static bool RequiresMarshal(Type t)
        {
            foreach (FieldInfo fieldInfo in t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                bool requires = fieldInfo.GetCustomAttributes(typeof(MarshalAsAttribute), true).Any();
                if (requires) return true;
                if (t == typeof(IntPtr) || t == typeof(string)) continue;
                if (Type.GetTypeCode(t) == TypeCode.Object) requires |= RequiresMarshal(fieldInfo.FieldType);
                if (requires) return true;
            }
            return false;
        }
        #endregion
    }
}