using System;

namespace MhLabs.Extensions
{
    public class Env
    {
        public static string Get(string key) => Environment.GetEnvironmentVariable(key);
    }
}