using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
  public  class Vertex
    {
        public string data { get; set; }
        public Node firstEdge { get; set; }
        public bool visited { get; set; }
        public Vertex(string val)
        {
            data = val;
            visited = false;
        }
    }
}
