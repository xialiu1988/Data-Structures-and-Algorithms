using System;
using QueueWithStacks;
using static QueueWithStacks.PseudoQueue;

namespace QueueWithStacks
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(4);
            Stack stack = new Stack(node1);

            stack.Push(20);
            stack.Push(32);
            stack.Push(2);
           stack.Push(14);
             PseudoQueue pse = new PseudoQueue(stack);
            pse.Print(stack);           
            pse.Enqueque(68);
           // pse.Front = stack;
            Console.WriteLine("+++++++++++++++++");
            pse.Print(stack);
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("afterDEqueue");
            pse.Dequeue();
           // pse.Front = stack;
            pse.Print(stack);
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("afterDEqueue");
            pse.Dequeue();
            pse.Print(stack);


        }
    }
}
