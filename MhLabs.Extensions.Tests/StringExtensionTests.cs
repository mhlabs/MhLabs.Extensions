using System;
using AutoFixture;
using Newtonsoft.Json;
using Xunit;

namespace MhLabs.Extensions.Tests
{
    public partial class StringExtensionTests
    {
        protected Fixture _fixture = new Fixture();
        public class ToUri : StringExtensionTests
        {
            [Fact]
            public void ToUri_ValidUri()
            {
                var uriString = "https://www.mathem.se";
                var uri = uriString.ToUri();
                Assert.Equal(uriString, uri.OriginalString);
            }

            [Fact]
            public void ToUri_InvalidUri_ShouldThrow()
            {
                var uriString = "https:/www.mathem.se";
                Assert.Throws<UriFormatException>(() => uriString.ToUri());
            }
        }

        public partial class To : StringExtensionTests
        {
            [Fact]
            public void To_ValidJson()
            {
                var item = _fixture.Create<TestItem>();
                var jsonString = JsonConvert.SerializeObject(item);
                var itemRestored = jsonString.To<TestItem>();
                Assert.Equal(item.Id, itemRestored.Id);
                Assert.Equal(item.Message, itemRestored.Message);
            }

            [Fact]
            public void To_InvalihdJson_ShouldTrow()
            {
                var jsonString = _fixture.Create<string>();

                Assert.Throws<JsonReaderException>(() => jsonString.To<TestItem>());
            }
        }
    }
}
