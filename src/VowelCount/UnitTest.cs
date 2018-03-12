using Xunit;

namespace VowelCount
{
    public class UnitTest
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(5, Kata.GetVouwelCount("abracadabra"));
            Assert.Equal(13, Kata.GetVouwelCount("hugomanuelnogueiraparedes"));
        }
    }
}
