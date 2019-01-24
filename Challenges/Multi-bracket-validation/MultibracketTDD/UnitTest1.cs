using System;
using Xunit;
using Multi_bracket_validation;

namespace MultibracketTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CheckTrueMultiBracket()
        {
            string s = "{{6789}}";
            bool boo = Program.MultiBracketValidation(s);

            Assert.True(boo);
        }



        [Fact]
        public void CheckFlaseMultiBracket()
        {
            string s = "{{[}]}";
            bool boo = Program.MultiBracketValidation(s);

            Assert.False(boo);
        }


        [Fact]
        public void CheckMultiBracket()
        {
            string s = "{452{[453552}]}";
            bool boo = Program.MultiBracketValidation(s);

            Assert.False(boo);
        }


    }
}
