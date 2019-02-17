using System;
using Newtonsoft.Json;

namespace MhLabs.Extensions
{
    public static class StringExtension
    {
        public static Uri ToUri(this string str) => new Uri(str);

        public static T To<T>(this string str) => JsonConvert.DeserializeObject<T>(str);
    }
}
