using System;
using Newtonsoft.Json;

namespace MhLabs.Extensions
{
    public static class ObjectExtension
    {
        public static string ToJson(this object obj) {
            return obj != null ? JsonConvert.SerializeObject(obj) : null;
        }
    }
}
