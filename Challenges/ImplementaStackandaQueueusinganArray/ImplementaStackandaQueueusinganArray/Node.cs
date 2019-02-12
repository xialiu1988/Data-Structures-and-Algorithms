using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementaStackandaQueueusinganArray
{
  public  class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T val)
        {
            Value = val;
        }
    }
}
