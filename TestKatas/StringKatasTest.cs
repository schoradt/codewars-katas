using System;
using Xunit;
using LibKatas;

namespace TestKatas
{
    public class StringKatasTest
    {
        [Theory]
        [InlineData("1 2 3 4 5", "5 1")]
        [InlineData("1 2 -3 4 5", "5 -3")]
        [InlineData("1 9 3 4 -5", "9 -5")]
        public void HighAndLowTest(string input, string expected)
        {
            var stringKatas = new StringKatas();
            var result = stringKatas.HighAndLow(input);

            Assert.Equal(expected, result);
        }
    }
}
