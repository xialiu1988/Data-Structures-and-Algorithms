using System;
using Xunit;
using Graphs;
using System.Collections.Generic;

namespace graphTDD
{
    public class UnitTest1
    { 

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
        /// An edge can be successfully added to the graph
        /// </summary>
        [Fact]
        public void canAddEdgetothegraph()
        {
            Graph p = new Graph();
            Vertex v1 = p.AddNode(1);
            p.AddEdge(v1, v1, 3);
            Assert.Equal(3, v1.firstEdge.Weight);
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
        /// <summary>
        /// can get neighbors
        /// </summary>
        [Fact]
        public void cangetneighbors()
        {
            Graph g = new Graph();
            Vertex v1 = g.AddNode(1);
            Vertex v2 = g.AddNode(2);
            Vertex v3 = g.AddNode(3);
            g.AddEdge(v1, v2, 10);
            g.AddEdge(v1, v3, 12);
            List<Vertex> list=g.GetNeighbors(v1);
            Assert.True(list.Count == 2);

        }
        /// <summary>
        /// canget proper size of the graph
        /// </summary>
        [Fact]
        public void canreturnpropsize()
        {
            Graph g = new Graph();
            Vertex v1 = g.AddNode(1);
            Vertex v2 = g.AddNode(2);
            Vertex v3 = g.AddNode(3);
            Vertex v4 = g.AddNode(4);

            Assert.True(g.Size() == 4);
        }

        /// <summary>
        /// one node and itsedge can be properly returned
        /// </summary>
        [Fact]
        public void onenodewithedge()
        {
            Graph g = new Graph();
            Vertex v1 = g.AddNode(1);
            g.AddEdge(v1, v1, 3);
            Assert.True(v1.firstEdge.Weight == 3);
        }
        /// <summary>
        /// null graph doesn't have size
        /// </summary>
        [Fact]
        public void nullgraph()
        {
            Graph g = new Graph();
            Assert.True(g.Size() == 0);
                
        }


        /// <summary>
        /// can get neighbors with weight
        /// </summary>
        [Fact]
        public void cangetneighborswithweight()
        {
            Graph g = new Graph();
            Vertex v1 = g.AddNode(1);
            Vertex v2 = g.AddNode(2);
            Vertex v3 = g.AddNode(3);
            g.AddEdge(v1, v2, 10);
            g.AddEdge(v1, v3, 12);
            List<(int,int)> list = g.GetNeighborswithweghts(v1);
            Assert.True(list.Count == 2);
            Assert.True(list[0]==(2,10));
            Assert.True(list[1] == (3, 12));
        }
    }
}
