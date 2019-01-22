using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
   public class PseudoQueue
    {
        public Stack Front { get; set; }
        public Stack Rear { get; set; }




        public PseudoQueue(Stack stack)
        {
            Front = stack;
            Rear = stack;

        }







    }


    /// <summary>
    ///  define a stack class
    /// </summary>

    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }
        //create an empty stack
        public Stack()
        {

        }


        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;

        }

        public Node Pop()
        {

            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;

        }

        public Node Peek()
        {
            return Top;
        }


    }

    /// <summary>
    ///  create a Node class
    /// </summary>

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }



    }


}
