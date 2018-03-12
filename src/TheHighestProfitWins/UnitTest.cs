using System;
using Xunit;

namespace TheHighestProfitWins
{
    public class UnitTest
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(new[] { 20, 20 }, Kata.MinMax(new[] { 20 }));
            Assert.Equal(new[] { -1, 20 }, Kata.MinMax(new[] { 1, 2, 5, -1, 12, 20 }));
            Assert.Equal(new[] { 1, 5 }, Kata.MinMax(new[] { 1, 2, 3, 4, 5 }));
            Assert.Equal(new[] { -3, 5 }, Kata.MinMax(new[] { 1, 2, -3, 4, 5 }));
        }
    }
}
