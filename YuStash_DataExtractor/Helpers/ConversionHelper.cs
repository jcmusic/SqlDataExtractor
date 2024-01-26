using System;
using System.Text;

namespace YuStashSageX3_ETL.Helpers
{
    public static class ConversionHelper
    {
        public static string EncodeBase64(string text)
        {
            var bytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }

        public static string DecodeBase64(string text)
        {
            var bytes = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
