using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
   public class Graph
    {
        public List<Vertex> Vertices { get; set; }
        //public Tuple<Node,Node> Edge { get; set; }
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
        public Vertex AddNode(int val)
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

            public void AddEdge(Vertex n1,Vertex n2)
        {
            foreach (Vertex v in Vertices)
            {
                if (!v.data.Equals(n1)||!v.data.Equals(n2))
                {
                    Console.WriteLine("You are missing vertex");
                }
               
            }
            AddEdgeOneway(n1, n2);
            AddEdgeOneway(n2, n1);

        }

        private void AddEdgeOneway(Vertex from, Vertex to)
        {
            if (from.firstEdge == null)
            {
                from.firstEdge = new Node(to);
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
                    temp.Next = new Node(to);//add to the last position of the list
                
            }
        }

        //getnodes()Returns all of the nodes in the graph as a collection (set, list, or similar)

            public List<Vertex> GetNodes()
        {
            return Vertices;
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
        /// Returns the total number of nodes in the graph
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return Vertices.Count;
        }
    }
}
