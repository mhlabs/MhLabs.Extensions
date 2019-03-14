using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using Xunit;

namespace MhLabs.Extensions.Tests
{
    public class CollectionExtensionTests
    {
        protected Fixture Fixture = new Fixture();
        public static IEnumerable<object[]> ListWithEntries;

        public CollectionExtensionTests()
        {
            ListWithEntries = Fixture.Create<IEnumerable<object[]>>();
        }

        public class IsNullOrEmpty : CollectionExtensionTests
        {
            [Fact]
            public void Should_return_true_when_null()
            {
                
                // Arrange
                IEnumerable<string> collection = null;

                // Act
                var isNullOrEmpty = collection.IsNullOrEmpty();

                // Assert
                Assert.True(isNullOrEmpty);
            }

            [Fact]
            public void Should_return_true_when_list_is_empty()
            {
                var collection = new List<string>();
                var isNullOrEmpty = collection.IsNullOrEmpty();
                Assert.True(isNullOrEmpty);
            }

            [Fact]
            public void Should_return_false_when_list_has_rows()
            {
                var collection = new List<string>() { "row1" };
                var isNullOrEmpty = collection.IsNullOrEmpty();
                Assert.False(isNullOrEmpty);
            }
        }
    }
}
