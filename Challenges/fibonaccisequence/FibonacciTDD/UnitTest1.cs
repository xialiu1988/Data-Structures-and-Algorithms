using System;
using Xunit;
using Fibonacci_Sequence;
namespace FibonacciTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnthe5thNumInFibonacci_Sequence()
        {
            Assert.Equal(3, Program.FibonacciSequence(5));
        }

   
        [Fact]
        public void CanReturnthe9thNumInFibonacci_Sequence()
        {
            Assert.Equal(21, Program.FibonacciSequence(9));
        }
    }
}
