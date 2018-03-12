using System;
using Xunit;

namespace DescendingOrder
{
    public class UnitTest
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(43211, Kata.DescendingOrder(11234));
            Assert.Equal(54421, Kata.DescendingOrder(21445));
            Assert.Equal(654321, Kata.DescendingOrder(145263));
            Assert.Equal(9875543221, Kata.DescendingOrder(1254859723));
            Assert.Equal(0, Kata.DescendingOrder(0));
        }
    }
}
