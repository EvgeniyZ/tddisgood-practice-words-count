using System;
using Xunit;

namespace WordsCountTests
{
    public class WordsCountTests
    {
        [Theory]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData("solve", 1)]
        [InlineData("TDD", 1)]
        [InlineData("I", 1)]
        [InlineData("I'm", 1)]
        [InlineData("I am", 2)]
        public void WordsCountTest(string line, int expectedCount)
        {
            Assert.Equal(expectedCount, WordsCount(line));
        }

        private int WordsCount(string line)
        {
            if (string.IsNullOrEmpty(line))
                return 0;
            return line
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }
    }
}
