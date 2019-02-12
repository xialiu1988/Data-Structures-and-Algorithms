using System;
using System.Collections.Generic;
using System.Text;

namespace Removeduplicatedvaluesfromalinked_list
{
   public class Node
    {

        public int Val { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Val = val;
        }
    }
}
