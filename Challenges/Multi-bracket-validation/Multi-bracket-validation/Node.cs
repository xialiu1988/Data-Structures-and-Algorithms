using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_bracket_validation
{
   public class Node
    {

        public char Val { get; set; }

        public Node Next { get; set; }

        public Node(char val)
        {
           Val=val;
        }



    }
}
