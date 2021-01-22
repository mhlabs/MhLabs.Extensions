using System;
using Newtonsoft.Json;

namespace MhLabs.Extensions
{
    public static class StringExtension
    {
        public static Uri ToUri(this string str) => new Uri(str);

        public static T To<T>(this string str) => str != null ? JsonConvert.DeserializeObject<T>(str) : default(T);
        
        public static string Truncate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str)) return str;
            return str.Length <= maxLength ? str : str.Substring(0, maxLength); 
        }
    }
}
