using System;
using System.Collections.Generic;
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




        //getnodes()Returns all of the nodes in the graph as a collection (set, list, or similar)
        // getneighborr()Returns a collection of nodes connected to the given node
        //Takes in a given node
        //Include the weight of the connection in the returned collection



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
