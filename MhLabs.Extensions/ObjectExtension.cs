using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MhLabs.Extensions
{
    public static class ObjectExtension
    {
        private static DefaultContractResolver _camelCaseResolver => new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        };

        public static string ToJson(this object obj, bool camelCase = false, Formatting formatting = Formatting.None)
        {
            return obj != null ? JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                ContractResolver = camelCase ? _camelCaseResolver : null,
                Formatting = formatting
            }) : null;
        }
    }
}
