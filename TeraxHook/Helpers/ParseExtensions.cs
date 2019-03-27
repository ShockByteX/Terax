using System;

namespace TeraxHook.Helpers
{
    public static class ParseExtensions
    {
        #region [PRIVATE]Fields
        private static readonly char[] HEX_CHARS = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        #endregion
        #region [PUBLIC]Methods
        public static bool IsHex(this char c)
        {
            int length = HEX_CHARS.Length;
            for (int i = 0; i < length; i++) { if (HEX_CHARS[i] == c) return true; }
            return false;
        }
        public static bool IsHex(this string text)
        {
            if (text.Length != 2) return false;
            bool result = true;
            foreach (char c in text) { if (!(result = result && c.IsHex())) return false; }
            return result;
        }
        public static byte ToByte(this string text) => Convert.ToByte(text, 16);
        public static string AsString(this byte[] data, int count = 8)
        {
            int length = data.Length < count ? data.Length : count;
            string result = null;
            for (int i = 0; i < length; i++)
            {
                string strByte = data[i].ToString("X");
                result += strByte.Length == 1 ? $"0{strByte} " : $"{strByte} ";
            }
            return result.Substring(0, result.Length - 1);
        }
        #endregion
    }
}