using Xunit;

namespace TripleDouble
{
    public class UnitTest
    {
        [Theory]
        [InlineData(451999277, 41177722899)]
        [InlineData(666789, 12345667)]
        [InlineData(10560002, 100)]
        public void BasicTestOne(long num1, long num2)
        {
            Assert.Equal(1, Kata.TripleDouble(num1, num2));
        }

        [Theory]
        [InlineData(1222345, 12345)]
        [InlineData(12345, 12345)]
        public void BasicTestZero(long num1, long num2)
        {
            Assert.Equal(0, Kata.TripleDouble(num1, num2));
        }
    }
}
