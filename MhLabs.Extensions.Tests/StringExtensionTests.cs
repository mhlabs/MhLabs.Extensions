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
                var nullItem = ((string)null).To<TestItem>();
                Assert.Equal(item.Id, itemRestored.Id);
                Assert.Equal(item.Message, itemRestored.Message);

                Assert.Equal(null, nullItem);
            }

            [Fact]
            public void To_InvalihdJson_ShouldTrow()
            {
                var jsonString = _fixture.Create<string>();

                Assert.Throws<JsonReaderException>(() => jsonString.To<TestItem>());
            }


            [Fact]
            public void To_NullDefaultsToDefault() {
                Assert.True("true".To<bool>());
                Assert.False("false".To<bool>());
                string nil = null;
                Assert.False(nil.To<bool>());
            }

        }

        public class Truncate : StringExtensionTests {
            [Theory]
            [InlineData("This is a simple string", 3)]
            [InlineData("Short string", 5)]
            [InlineData("Awesome string", 1)]
            public void Should_Trucate_String(string input, int maxLength)
            {
                var result = input.Truncate(maxLength);
                Assert.Equal(maxLength, result.Length);
            }

            [Theory]
            [InlineData("This is a simple string", -1)]
            [InlineData("Short string", -20)]
            public void Should_Throw_When_Max_Length_Is_Negative(string input, int maxLength)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => input.Truncate(maxLength));
            }

            [Theory]
            [InlineData("This is a simple string", 0)]
            [InlineData("Short string", null)]
            public void Should_Respect_Null_And_Zero_As_Max_Length(string input, int maxLength)
            {
                var result = input.Truncate(maxLength);
                Assert.Equal(0, result.Length);
            }

            [Fact]
            public void Should_Truncate_Whitespace()
            {
                var input = " < ";

                var result = input.Truncate(0);
                
                Assert.Equal(0, result.Length);
            }
        }


    }
}
