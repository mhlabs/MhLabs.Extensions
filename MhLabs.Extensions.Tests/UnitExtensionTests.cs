using Xunit;

namespace MhLabs.Extensions.Tests
{
    public class UnitExtensionTests
    {

        [Fact]
        public void Should_Get_MinorUnit_From_Decimal()
        {
            // arrange
            var amount = 100.00M;
            var expected = 10000;

            // act
            var actual = amount.ToMinorUnit();

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Get_MinorUnit_From_Double()
        {
            // arrange
            var amount = 100.00D;
            var expected = 10000;

            // act
            var actual = amount.ToMinorUnit();

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Get_MajorUnit_In_Decimal_Format()
        {
            // arrange
            var amount = 10000;
            var expected = 100.00M;

            // act
            var actual = amount.ToMajorUnit<decimal>();
            
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Get_MajorUnit_In_Double_Format()
        {
            // arrange
            var amount = 10000;
            var expected = 100.00D;

            // act
            var actual = amount.ToMajorUnit<double>();

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
