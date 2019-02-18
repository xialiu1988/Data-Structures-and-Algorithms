using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
   public class Node
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node()
        {

        }
        public Node(int key,string val)
        {
            Key = key;
            Value = val;
        }
    }
}
