using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_bracket_validation
{
  public class Stack
    {
        public Node Top { get; set; }
        /// <summary>
        /// just create an empty stack constructor
        /// </summary>
        public Stack()
        {

        }

        public void Push(char c)
        {
            Node node = new Node(c);
            if (Top == null) { Top = node; }
            else
            {
                node.Next = Top;
                Top = node;
            }
        }


        /// <summary>
        /// pop a node from stack
        /// </summary>
        /// <returns></returns>

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
}
