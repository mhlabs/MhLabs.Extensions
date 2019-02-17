using System;
using Newtonsoft.Json;

namespace MhLabs.Extensions
{
    public static class ObjectExtension
    {
        public static string ToJson(this object obj) => JsonConvert.SerializeObject(obj);
    }
}
