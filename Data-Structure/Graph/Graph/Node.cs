using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
   public class Node
    {
        public Vertex V{ get; set; }
       public Node Next { get; set; }
        public int Weight { get; set; }
        /// <summary>
        ///Node constructor
        /// </summary>
        /// <param name="val"></param>
        public Node(Vertex v,int weight)
        {
            V = v;
            Weight = weight;
          
        }
    }
}
