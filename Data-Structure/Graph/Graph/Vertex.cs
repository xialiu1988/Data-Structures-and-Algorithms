using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
  public  class Vertex
    {
        public int data { get; set; }
        public Node firstEdge { get; set; }
        public bool visited { get; set; }
        public Vertex(int val)
        {
            data = val;
        }
    }
}
