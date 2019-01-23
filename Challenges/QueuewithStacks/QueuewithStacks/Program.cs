﻿using System;
using QueuewithStacks;
using static QueuewithStacks.PseudoQueue;

namespace QueuewithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Node node1 = new Node(4);
            Stack stack = new Stack(node1);
            //Stack stack = new Stack();
            stack.Push(20);
            stack.Push(32);
            stack.Push(2);
            stack.Push(14);
            PseudoQueue pse = new PseudoQueue(stack);
            pse.Print(stack);
            pse.Enqueque(68);

            Console.WriteLine("+++++++++++++++++");
            pse.Print(stack);
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("afterDEqueue");
            pse.Dequeue();

           pse.Print(stack);
            //Console.WriteLine("+++++++++++++++++");
            //Console.WriteLine("afterDEqueue");
            //pse.Dequeue();
            //pse.Print(stack);


        }
    }
}
