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

        public void Enqueque(int value)
        {
            Stack temp = new Stack();
            while (Front.Top.Next != null)
            {
                Node tempNode = Front.Pop();
                temp.Push(tempNode.Value);
            }
            Node tempNode2 = Front.Pop();
            temp.Push(tempNode2.Value);

            //push the new node to the stack
            Front.Push(value);

            while (temp.Top.Next != null)
            {
                Node tempNode = temp.Pop();
               
                Front.Push(tempNode.Value);

            }
            Node tempNode3 = temp.Pop();

            Front.Push(tempNode3.Value);
        }

        
        public void Dequeue()
        {
          Node pop= Front.Pop();

            Console.WriteLine(pop.Value);

        }




        public void Print(Stack stack)
        {
            Node current = stack.Top;
            int counter = 0;
            while (current.Next != null)
            {
                counter++;
                current = current.Next;
            }
            counter++;

            int[] arr = new int[counter];
            current = stack.Top;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = current.Value;
                current = current.Next;
            }

            for(int i = arr.Length-1; i >=0; i--)
            {
                Console.Write(arr[i] + " " + "=>");
            }
            Console.WriteLine("end");
            Front = stack;
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
}