using System;
using Xunit;

namespace MhLabs.Extensions.Tests
{
    public class EnvTests
    {
        [Fact]
        public void GetExisting() {
            Environment.SetEnvironmentVariable("key", "value");
            var value = Env.Get("key");
            Assert.Equal("value", value);
        }
    }
}