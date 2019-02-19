using System;
using Xunit;
using RepeatedWord;

namespace repeatedwordTDD
{
    public class UnitTest1
    {
        [Fact]
        public void canfindwod()
        {
            string str3 = "Once upon a time, there was a brave princess who...";
           string s= Program.RepeatedWord(str3);
            Assert.True(s == "a");
        }


        [Fact]
        public void canfindaword()
        {
            string str2 = "It was a queer, sultry summer the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            string s = Program.RepeatedWord(str2);
            Assert.True(s == "summer");
        }
        /// <summary>
        /// case does not matter,still find the word it
        /// </summary>
        [Fact]
        public void canfindatheword()
        {
            string str = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."
;
            string s = Program.RepeatedWord(str);
            Assert.True(s == "it");
        }

    }
}
