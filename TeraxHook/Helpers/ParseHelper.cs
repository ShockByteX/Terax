using System;
using System.Linq;

namespace TeraxHook.Helpers
{
    public static class ParseHelper
    {
        #region Fields
        public static readonly string[] BTS_ARRAY = new string[256];
        #endregion
        #region Constructors
        static ParseHelper()
        {
            for (int i = 0; i < 256; i++)
            {
                string strByte = i.ToString("X");
                if (strByte.Length == 1) BTS_ARRAY[i] = $"0{strByte}"; else BTS_ARRAY[i] = strByte;
            }
        }
        #endregion
        #region Methods
        public static byte[] BytesFromPattern(string pattern, out byte dByte)
        {
            string[] arrBytes = pattern.Split(' ');
            dByte = 0x00;
            for (byte i = 0; i <= byte.MaxValue; i++) { if (!arrBytes.Contains(BTS_ARRAY[i])) { dByte = i; break; } }
            byte[] buffer = new byte[arrBytes.Length];
            for (int i = 0; i < arrBytes.Length; i++) { if (arrBytes[i] == "?") buffer[i] = dByte; else buffer[i] = Convert.ToByte(arrBytes[i], 16); }
            return buffer;
        }
        #endregion
    }
}