using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
   public class Node
    {
        public Vertex V{ get; set; }
       public Node Next { get; set; }
        /// <summary>
        ///Node constructor
        /// </summary>
        /// <param name="val"></param>
        public Node(Vertex v)
        {
            V = v;
          
        }
    }
}
