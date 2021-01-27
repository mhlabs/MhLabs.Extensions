using System;
using System.Net;
using Xunit;

namespace MhLabs.Extensions.Tests
{
    public class HttpStatusCodeExtensionTests
    {
        public class IsSuccessful : HttpStatusCodeExtensionTests
        {
            [Theory]
            [InlineData(200, true)]
            [InlineData(301, false)]
            [InlineData(204, true)]
            [InlineData(500, false)]
            [InlineData(409, false)]
            public void Should_Return_True_If_StatusCode_Is_Between_200_And_299(int statusCode, bool expected)
            {
                // arrange
                var httpStatusCode = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), statusCode.ToString());

                // act
                var actual = httpStatusCode.IsSuccessful();

                // assert
                Assert.Equal(expected, actual);
            }
        }
    }
}
