using System;

namespace Tera.Core.Internals
{
    public static class ArrayExtensions
    {
        public static T[] Take<T>(this T[] array, int index, int length)
        {
            if (index + length > array.Length) throw new ArgumentOutOfRangeException(nameof(length));
            T[] buffer = new T[length];
            for (int i = 0; i < length; i++) buffer[i] = array[i + index];
            return buffer;
        }
    }
}