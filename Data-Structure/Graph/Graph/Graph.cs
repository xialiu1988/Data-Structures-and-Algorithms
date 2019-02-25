using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
   public class Graph
    {
        public List<Vertex> Vertices { get; set; }
    
        /// <summary>
        /// graph constructor 
        /// </summary>
        public Graph()
        {
            Vertices = new List<Vertex>();

        }
       
        /// <summary>
        /// Adds a new node to the graph
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Returns the added node</returns>
        public Vertex AddNode(string val)
        {
           Vertex node = new Vertex(val);
            if (Vertices.Contains(node))
            {
                Console.WriteLine("already exsits");
                return null;
            }
            else
            {
                Vertices.Add(node);
                return node;
            }
        }


        //addedge()Adds a new edge between two nodes in the graph
        //        Include the ability to have a “weight”
        //Takes in the two nodes to be connected by the edge
        //Both nodes should already be in the Graph

            public void AddEdge(Vertex n1,Vertex n2,int weight)
        {
            //foreach (Vertex v in Vertices)
            //{
            //    if (!v.data.Equals(n1)||!v.data.Equals(n2))
            //    {
            //        Console.WriteLine("You are missing vertex");
            //    }
               
            //}
            AddEdgeOneway(n1, n2,weight);
            AddEdgeOneway(n2, n1,weight);

        }

        private void AddEdgeOneway(Vertex from, Vertex to,int weight)
        {
            if (from.firstEdge == null)
            {
                from.firstEdge = new Node(to,weight);
            }
            else
            {
                Node node = from.firstEdge;
                Node temp;
                do
                {
                    if (node.V.data.Equals(to.data))
                    {
                        Console.WriteLine("already Exsits this edge");
                    }

                    temp = node;
                    node = node.Next;
                } while (node != null);
                    temp.Next = new Node(to,weight);//add to the last position of the list
                
            }
        }

        //getnodes()Returns all of the nodes in the graph as a collection (set, list, or similar)

            public List<Vertex> GetNodes()
        {
            return Vertices;
        }

        public void Print(List<Vertex> list)
        {
            Vertex v;
            for(int i = 0; i < list.Count; i++)
            {
                v = list[i];
                Node n = v.firstEdge;
                Console.Write($"vertex is {v.data}.its list :");
                while (n != null)
                {
                    Console.Write("("+n.V.data + ","+n.Weight+")"+"->");
                    n = n.Next;

                }
                Console.Write("null");
                 Console.WriteLine();

            }

        }
        // getneighborr()Returns a collection of nodes connected to the given node
        //Takes in a given node
        //Include the weight of the connection in the returned collection

            public List<Vertex> GetNeighbors(Vertex n)
        {
            List<Vertex> neighbors = new List<Vertex>();
            int index = Vertices.IndexOf(n);
            if (Vertices[index].firstEdge != null)
            {
                Node temp = Vertices[index].firstEdge;
                while (temp != null)
                {
                    neighbors.Add(temp.V);
                    temp = temp.Next;
                }
            }
            return neighbors;
        }
        /// <summary>
        /// get neighbors with nodes' weights
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public List<(string,int)> GetNeighborswithweghts(Vertex v)
        {
            List<(string, int)> neighbors = new List<(string, int)>();
            
            int index = Vertices.IndexOf(v);
            if(Vertices[index].firstEdge!=null)
            {
                Node temp = Vertices[index].firstEdge;
                while (temp != null)
                {
                    neighbors.Add((temp.V.data, temp.Weight));
                    temp = temp.Next;
                }
            }

            return neighbors;
        }


        /// <summary>
        /// Returns the total number of nodes in the graph
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return Vertices.Count;
        }
    }
}
