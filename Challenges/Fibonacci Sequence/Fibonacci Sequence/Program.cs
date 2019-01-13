using System;

namespace Fibonacci_Sequence
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           int answer= FibonacciSequence(7);
            Console.WriteLine(answer);
        }

        public static int FibonacciSequence(int n)
        {
            int firstNum = 0;
            int secNum = 1;
            int Result = 0;

                for (int i = 2; i < n; i++)
                {
                Result = firstNum + secNum;
                firstNum = secNum;
                    secNum = Result;

                }

                return Result;

            }

 
    }
}
