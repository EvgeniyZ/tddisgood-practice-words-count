using System;
using Xunit;

namespace WordsCountTests
{
    public class WordsCountTests
    {
        [Fact]
        public void EmptyLineTest()
        {
            var line = "";
            Assert.Equal(0, WordsCount(line));
        }

        private int WordsCount(string line)
        {
            return 0;
        }
    }
}
