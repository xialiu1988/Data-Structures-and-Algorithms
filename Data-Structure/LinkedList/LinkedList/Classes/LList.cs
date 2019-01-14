using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Node insertNode = new Node(value);
            insertNode.Next = Head;
            Head = insertNode;
        }

        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;

                
            }
            if (Current.Value == value) return true;


            return false;
        }
     

        public void print()
        {
            Current = Head;
            while (Current != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }

        }

    }
}
