using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementaStackandaQueueusinganArray
{
    public class Stack<T> 
    {
       
        public T Top { get; set; }
        T[] nodes = new T[5];
        int currentIndex = 0;
        int counter = 0;
        public Stack(T node)
        {
            Top = node;
        }

        public Stack()
        {

        }

        
        public void Push(T val)
        {
            if (currentIndex > nodes.Length)
            {
                Array.Resize(ref nodes, nodes.Length * 2);
            }
          
            nodes[currentIndex] = val;
            currentIndex++;
            counter++;
            
        }


        public T Pop()
        {
            T last = nodes[nodes.Length - 1];
            T[] temp = nodes.Where((val, idx) => idx != (nodes.Length - 1)).ToArray();
            Array.Copy(temp, nodes, temp.Length);

            counter--;
            return last;


        }

    }
}
