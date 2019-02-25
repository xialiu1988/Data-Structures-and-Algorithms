using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
   public class Node
    {
        public int Value { get; set; }
        public List<Node> Neighbors { get; set; }
        public bool Visited { get; set; }
        public  int Degree { get; set; }
        /// <summary>
        ///Node constructor
        /// </summary>
        /// <param name="val"></param>
        public Node(int val)
        {
            Value = val;
            Neighbors = new List<Node>();
            Visited = false;
            Degree = Neighbors.Count;
        }
    }
}
