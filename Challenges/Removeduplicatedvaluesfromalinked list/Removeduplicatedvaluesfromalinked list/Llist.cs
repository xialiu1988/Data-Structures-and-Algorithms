using System;
using System.Collections.Generic;
using System.Text;

namespace Removeduplicatedvaluesfromalinked_list
{
   public class Llist
    {
        public Node Head { get; set; }
        public Node Curr { get; set; }




        public void Insert(int value)
        {
            Node insertNode = new Node(value);
            insertNode.Next = Head;
            Head = insertNode;
        }



        public void Append(int value)
        {
            while (Curr.Next != null)
            {
                Curr = Curr.Next;
            }

            Node node = new Node(value);

            Curr.Next = node;

        }

        /// <summary>
        /// output all nodes' values 
        /// </summary>
        public void print()
        {
            if (Head != null)
            {
                Curr = Head;
                while (Curr.Next != null)
                {
                    Console.Write($"{Curr.Val} =>");
                    Curr = Curr.Next;
                }

                Console.WriteLine($"{Curr.Val} => Null");
            }
            else
            {
                Console.WriteLine("This is an empty list");
            }
        }
    }
}
