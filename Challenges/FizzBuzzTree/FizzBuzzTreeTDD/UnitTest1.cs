using System;
using Xunit;
using FizzBuzzTree;
namespace FizzBuzzTreeTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanFizz()
        {
           Tree tr= Program.GetaTree();
           Program.FizzBuzzTree(tr.Root);
            Assert.Equal("Fizz", tr.preOrder()[0]);

        }



        [Fact]
        public void CanTestBuzz()
        {
            Tree tr = Program.GetaTree();
            Program.FizzBuzzTree(tr.Root);
            Assert.Equal("Buzz", tr.preOrder()[2]);

        }



        [Fact]
        public void TestFizzBuzz()
        {
            Tree tr = Program.GetaTree();
            Program.FizzBuzzTree(tr.Root);
            Assert.Equal("FizzBuzz", tr.preOrder()[4]);

        }
    }
}
