using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

/// <summary>
/// Insert method to insert a node with value in the list
/// </summary>
/// <param name="value"></param>
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
     
        /// <summary>
        ///output the list
        /// </summary>
        public void print()
        {
            if (Head != null) {

                Current = Head;
                while (Current.Next!= null)
                {
                    
                    Console.Write($"{Current.Value} => ");
                    Current = Current.Next;

                }
                Console.WriteLine($"{Current.Value}=>Null");
            }
            else
            {
                Console.WriteLine("Your linked list is empty.");
            }


        }


        public void Append(int value)
        {
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Node node = new Node(value);

            Current.Next = node;

        }

        public void InsertBefore(int value,int newvalue)
        {

            Current = Head;
            if (Current.Value == value)
            {
                Insert(newvalue);
                return;

            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newvalue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }

        }




        public void InsertAfter(int value, int newvalue)
        {

            Current = Head;
            if (Current == null)
            {
                Console.WriteLine("Empty List");
                return;
            }
            if (Current.Value == value)
            {
                Node newNode = new Node(newvalue);
                newNode.Next = Current.Next;
                Current.Next = newNode;
                return;
            }
           

            while (Current.Next != null)
            {

                if (Current.Value == value)
                {
                    Node newNode = new Node(newvalue);
                  newNode.Next=Current.Next;
                    Current.Next = newNode;

                }
                Current = Current.Next;

            }


            if (Current.Value == value)
            {
                Node newNode = new Node(newvalue);
                newNode.Next = Current.Next;
                Current.Next = newNode;

            }
            return;
        }


        public int GetValue(int k)
        {
            
            Current = Head;
            int counter = 0;


            while (Current.Next != null)
            {
                Current = Current.Next;
                counter++;
            }

            counter++;

            Current = Head;
            int counter2 = 0;
            while (Current.Next != null)
            { counter2++;
                if (counter2 + k == counter) return Current.Value;
                Current = Current.Next;
            }

            counter2++;
            if (counter2 + k == counter) return Current.Value;
            else
            {
                Console.Write("Exception!");
                return -1;
            }

        }



    }
}
