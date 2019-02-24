using System;
using Xunit;
using MockInterview1_MostCommonWordInaBook;
namespace MostCommonWordTDD
{
    public class UnitTest1
    {   /// <summary>
    /// test most common word in a string
    /// </summary>
        [Fact]
        public void cangetmostcommonwordfromastring()
        {
            string s1 = "In a galaxy far far away";
            string res = Program.MostCommonwordInbook(s1);
            Assert.True(res == "far");
        }


        /// <summary>
        /// test most common word with "." in a string
        /// </summary>
        [Fact]
        public void cangetmostcommonword()
        {
            string s1 = "No.Try not.Do or do not.There is no try.";         
            string res = Program.MostCommonwordInbook(s1);
            Assert.True(res == "no");
        }

        /// <summary>
        /// will return fist most common word in a string
        /// </summary>
        [Fact]
        public void cangetfirstmostword()
        {
            string s1 = "dog dog cat cat";
            string res = Program.MostCommonwordInbook(s1);
            Assert.True(res == "dog");
        }
    }
}
