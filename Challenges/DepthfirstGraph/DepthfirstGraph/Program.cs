using System;
using System.Collections.Generic;
using Graphs;
namespace DepthfirstGraph
{
   
    public  class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph g = new Graph();
            Vertex v1=g.AddNode("a");
           Vertex v2= g.AddNode("b");
            Vertex v3=g.AddNode("c");
           Vertex v4= g.AddNode("d");

            g.AddEdge(v1, v2, 20);
            g.AddEdge(v2, v3, 1);
            g.AddEdge(v1, v4, 3);
            g.AddEdge(v2, v4, 5);
            foreach (Vertex v in g.Vertices)
            {
                Console.WriteLine(v.data);
            }

            Console.WriteLine("==================");
            List<string> s = new List<string>();
         List< string> res= DFS(g.Vertices[0],s);
           // Console.WriteLine(res.Count);
            foreach (string ss in res)
            {
                Console.WriteLine(ss);
            }
        }
       
        /// <summary>
        /// depth first traversal DFS using recursive method
        /// </summary>
        /// <param name="v"></param>
        public static List<string> DFS(Vertex v,List<string> s)
        {
          
            v.visited = true;
            s.Add(v.data);
            // Console.Write(v.data);
                  Node n = v.firstEdge;
            while (n != null)
            {
                if (n.V.visited == false)
                {
                    DFS(n.V,s);
                }
                n = n.Next;
            }
            return s;
        }

      
    }
}
