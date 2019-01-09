using System;
using Xunit;
using arrayshift;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] test = { 2, 4, 6, 8 };
            int value = 5;
            int[] expected = { 2, 4, 5, 6, 8 };

            Assert.Equal(expected, Program.ArrayShift(test, value));


        }




        [Fact]
        public void Test2()
        {
            int[] test = { 4, 8, 15, 23, 42 };
            int value = 16;
            int[] expected = { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(expected, Program.ArrayShift(test, value));


        }

        [Fact]
        public void Test3()
        {
            int[] test = { 2 };
            int value = 5;
            int[] expected = { 2, 5 };

            Assert.Equal(expected, Program.ArrayShift(test, value));


        }


    }
}
