using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tera.Core.Internals
{
    public static class StringExtensions
    {
        public static string ToTeraString(this byte[] data, ref int offset)
        {
            string text = null;
            for (char c = BitConverter.ToChar(data, offset); (c = BitConverter.ToChar(data, offset)) != char.MinValue; offset += 2) text += c;
            return text;
        }
        public static byte[] ToTeraBytes(this string text)
        {
            byte[] data = new byte[Encoding.Unicode.GetByteCount(text) + 6];
            return data;
        }
        public static string AsString(this byte[] data, int count = 8)
        {
            int length = data.Length < count ? data.Length : count;
            string result = null;
            for (int i = 0; i < length; i++)
            {
                string strByte = data[i].ToString("X");
                result += strByte.Length == 1 ? $"0{strByte} " : $"{strByte} ";
            }
            return result;
        }
    }
}