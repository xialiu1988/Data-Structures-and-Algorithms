using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
   public class Queue
    {

        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;

        }
        /// <summary>
        /// added a node into the queue
        /// </summary>
        /// <param name="value"></param>

        public void Enqueue(int value)
        {
            Node node = new Node(value);

            Rear.Next = node;
            Rear = node;
        }
        /// <summary>
        /// remove the front node from the queue
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            Node temp = Front;

            Front = Front.Next;
            temp.Next = null;

            return temp;
            
        }

        /// <summary>
        /// return the front node 
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Front;
        }

    }
}
