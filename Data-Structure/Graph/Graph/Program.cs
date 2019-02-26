using System;
using System.Collections.Generic;

namespace Graphs
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("===");
            Graph g = new Graph();
            Vertex v1 = g.AddNode("a");
            Console.WriteLine(v1.data);
            Vertex v2 = g.AddNode("b");
            Vertex v3 = g.AddNode("c");
            Vertex v4 = g.AddNode("d");

            g.AddEdge(v1, v2, 10);
            g.AddEdge(v1, v3, 14);
            g.AddEdge(v2, v4, 13);

            g.Print(g.Vertices);
            Console.WriteLine("===");
            Console.WriteLine("===");
           List<Vertex> res= g.BFSTraverse();
            foreach (Vertex v in res)
            {
                Console.WriteLine(v.data);
            }
        }
    }
}
