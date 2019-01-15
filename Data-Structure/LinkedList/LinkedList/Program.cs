using LinkedList.Classes;
using System;

namespace LinkedList
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            LList list = new LList();
            int[] numsArr = { 2, 4, 6, 7, 10, 98, 21 };
            for(int i = 0; i < numsArr.Length; i++)
            {
                list.Insert(numsArr[i]);

            }
            list.print();
            list.Append(43);
            list.print();

        }
    }
}
