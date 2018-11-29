using System;
using Xunit;
using LibKatas;

namespace TestKatas
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(5, 7, 10, true)]
        [InlineData(1, 2, 4, false)]
        [InlineData(4, 1, 2, false)]
        [InlineData(1, 4, 2, false)]
        [InlineData(1, 2, 3, false)]
        [InlineData(3, 2, 1, false)]
        [InlineData(2, 3, 1, false)]
        public void IsTriangleTest(int a, int b, int c, bool result)
        {
            Assert.Equal(Triangle.IsTriangle(a, b, c), result);
        }
    }
}
