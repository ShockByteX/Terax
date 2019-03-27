namespace Test.Extensions
{
    public static class ParseExtensions
    {
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