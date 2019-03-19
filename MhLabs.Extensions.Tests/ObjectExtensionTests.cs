using System;
using AutoFixture;
using Xunit;

namespace MhLabs.Extensions.Tests
{
    public class ObjectExtensionTests
    {
        protected Fixture _fixture = new Fixture();

        public class ToJson : ObjectExtensionTests {
            [Fact]
            public void ValidObject() {
                var item = _fixture.Create<TestItem>();
                var json = item.ToJson();
                Assert.Contains(item.Id, json);
                Assert.Contains(item.Message, json);
            }

            [Fact]
            public void Null_ShouldReturnNull() {
                TestItem item = null;
                var json = item.ToJson();
                Assert.Null(json);
            }

            [Fact]
            public void CamelCaseTest() {
                TestItem item = _fixture.Create<TestItem>();
                var json = item.ToJson(true);
                Assert.Contains("\"message\"", json, StringComparison.InvariantCulture);
            }

            [Fact]
            public void PascalCaseTest() {
                TestItem item = _fixture.Create<TestItem>();
                var json = item.ToJson();
                Assert.Contains("\"Message\"", json, StringComparison.InvariantCulture);
            }
        }
    }
}