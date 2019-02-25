using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
   public class Graph
    {
        public List<Node> Vertices { get; set; }
        //public Tuple<Node,Node> Edge { get; set; }
        /// <summary>
        /// graph constructor 
        /// </summary>
        public Graph()
        {

        }
       
        /// <summary>
        /// Adds a new node to the graph
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Returns the added node</returns>
        public Node AddNode(int val)
        {
            Node node = new Node(val);
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

            public void AddEdge(Node n1,Node n2,int? weight)
        {
            if (n1.Neighbors.Contains(n2))
            {
                Console.WriteLine("already exsits");
            }
            else
            {
                n1.Neighbors.Add(n2);
                n2.Neighbors.Add(n1);

            }


        }


        //getnodes()Returns all of the nodes in the graph as a collection (set, list, or similar)

            public List<Node> GetNodes()
        {
            return Vertices;
        }


        // getneighborr()Returns a collection of nodes connected to the given node
        //Takes in a given node
        //Include the weight of the connection in the returned collection

            public List<Node> GetNeighbors(Node n)
        {
            int index = Vertices.IndexOf(n);
            return Vertices[index].Neighbors;


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
