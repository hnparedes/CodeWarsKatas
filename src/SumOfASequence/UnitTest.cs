using Xunit;

namespace SumOfASequence
{
    public class UnitTest
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(12, Kata.SequenceSum(2, 6, 2));
            Assert.Equal(15, Kata.SequenceSum(1, 5, 1));
            Assert.Equal(5, Kata.SequenceSum(1, 5, 3));
            Assert.Equal(45, Kata.SequenceSum(0, 15, 3));
            Assert.Equal(0, Kata.SequenceSum(16, 15, 3));
            Assert.Equal(26, Kata.SequenceSum(2, 24, 22));
            Assert.Equal(2, Kata.SequenceSum(2, 2, 2));
            Assert.Equal(2, Kata.SequenceSum(2, 2, 1));
            Assert.Equal(35, Kata.SequenceSum(1, 15, 3));
            Assert.Equal(0, Kata.SequenceSum(15, 1, 3));
        }
    }
}
