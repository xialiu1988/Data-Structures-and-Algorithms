using System;

namespace Graphs
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Graph g = new Graph();
           Vertex v1= g.AddNode(1);
           Vertex v2= g.AddNode(2);
           Vertex v3= g.AddNode(3);
            Vertex v4=g.AddNode(4);

            g.AddEdge(v1, v2, 10);
            g.AddEdge(v1, v3, 14);
            g.AddEdge(v2, v4, 13);

            g.Print(g.Vertices);
        }
    }
}
