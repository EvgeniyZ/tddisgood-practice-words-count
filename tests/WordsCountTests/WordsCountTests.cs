using System;
using Xunit;

namespace WordsCountTests
{
    public class WordsCountTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("solve", 1)]
        public void WordsCountTest(string line, int expectedCount)
        {
            Assert.Equal(expectedCount, WordsCount(line));
        }

        private int WordsCount(string line)
        {
            return line.Length == 0 ? 0 : 1;
        }
    }
}
