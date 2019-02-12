using System;
using System.Collections.Generic;
using System.Text;

namespace ShuffleALinkedList
{
   public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
      public int counter { get; set; }//total number of nodes in the list

       
        public void Insert(int val)
        {
            Node node = new Node(val);
            node.Next = Head;
            Head = node;
            counter++;
        }

        public Node GetLastNode()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            return Current;

        }

        public void print()
        {
            if (Head != null)
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Console.Write($"{Current.Value} => ");
                    Current = Current.Next;

                }
                Console.WriteLine($"{Current.Value}=>Null");
            }

            else
            {
                Console.WriteLine("This is an empty linked list");
            }
        }
    }
}
