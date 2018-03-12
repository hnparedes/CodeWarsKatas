using Xunit;

namespace DoNotGiveMeFive
{
    public class UnitTest
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(8, Kata.DontGiveMeFive(1, 9));
            Assert.Equal(12, Kata.DontGiveMeFive(4, 17));
        }
    }
}
