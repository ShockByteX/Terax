using System;

namespace Tera.Core
{
    public static class Extensions
    {
        public static T[] Slice<T>(this T[] array, int start, int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException(nameof(length));
            T[] arr = new T[length];
            Array.Copy(array, start, arr, 0, length);
            return arr;
        }
    }
}