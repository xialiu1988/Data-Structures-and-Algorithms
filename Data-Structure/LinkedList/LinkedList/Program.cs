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
            list.Insert(2);
            list.Insert(4);
            list.Insert(6);
            list.Insert(7);
            list.Insert(79);
            list.print();
            list.InsertAfter(6, 88);
            list.print();
            list.InsertBefore(6, 48);
            list.Append(43);
            list.print();
            Console.WriteLine("...............");
           int a= list.GetValue(9);
            int b = list.GetValue(0);
            int c = list.GetValue(4);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
