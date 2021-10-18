using Xunit;

namespace MhLabs.Extensions.Tests
{
    public class UnitExtensionTests
    {

        [Fact]
        public void Should_Get_MinorUnit_From_Decimal()
        {
            // arrange
            var amount = 809.95M;
            var expected = 80995;

            // act
            var actual = amount.ToMinorUnit();

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Get_MinorUnit_From_Double()
        {
            // arrange
            var amount = 809.95M;
            var expected = 80995;

            // act
            var actual = amount.ToMinorUnit();

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Get_MajorUnit_In_Decimal_Format()
        {
            // arrange
            var amount = 80995;
            var expected = 809.95M;

            // act
            var actual = amount.ToMajorUnit<decimal>();
            
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Get_MajorUnit_In_Double_Format()
        {
            // arrange
            var amount = 80995;
            var expected = 809.95D;

            // act
            var actual = amount.ToMajorUnit<double>();

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
