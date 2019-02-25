using System;
using Xunit;
using Graphs;
using System.Collections.Generic;

namespace graphTDD
{
    public class UnitTest1
    {
     //A collection of all nodes can be properly retrieved from the graph
     //All appropriate neighbors can be retrieved from the graph
     //Neighbors are returned with the weight between nodes included
     //The proper size is returned, representing the number of nodes in the graph
     //A graph with only one node and edge can be properly returned
     //An empty graph properly returns null
     /// <summary>
     /// add a node to graph
     /// </summary>
        [Fact]
        public void canAddNodetothegraph()
        {
            Graph p = new Graph();

           Vertex v1= p.AddNode(1);
            Assert.Equal(1, v1.data);
        }
        /// <summary>
        /// get allnodes
        /// </summary>
        [Fact]
        public void canretrievedallnodesfromgraph()
        {
            Graph g = new Graph();
            Vertex v1 = g.AddNode(1);
            Vertex v2 = g.AddNode(2);
            Vertex v3 = g.AddNode(3);
            Vertex v4 = g.AddNode(4);

           List<Vertex> list= g.GetNodes();
            Assert.True(list.Count == 4);
            Assert.True(list[0].data == 1);
            Assert.True(list[1].data == 2);
            Assert.True(list[2].data == 3);
            Assert.True(list[3].data == 4);

        }
        

    }
}
