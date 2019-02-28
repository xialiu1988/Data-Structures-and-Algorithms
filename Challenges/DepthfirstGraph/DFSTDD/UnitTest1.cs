using System;
using Xunit;
using Graphs;
using DepthfirstGraph;
using Program = DepthfirstGraph.Program;
using System.Collections.Generic;

namespace DFSTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// CAN depth first traversal graph
        /// </summary>
        [Fact]
        public void dfsgraph()
        {
            Graph g = new Graph();
           Vertex v1= g.AddNode("a");
            Vertex v2 = g.AddNode("b");
            g.AddEdge(v1, v2, 3);
            List<string> s = new List<string>();
            List<string> list = Program.DFS(g.Vertices[0], s);
         Assert.Equal(2,list.Count);
            Assert.Contains("a", list);
            Assert.Contains("b", list);
        }

        /// <summary>
        /// one node 
        /// </summary>
        [Fact]
        public void dfs()
        {
            Graph g = new Graph();
            Vertex v1 = g.AddNode("a");
             Vertex v2 = g.AddNode("b");
            Vertex v3 = g.AddNode("c");
            g.AddEdge(v1, v2, 3);
            g.AddEdge(v2, v3, 3);
            g.AddEdge(v1, v3, 3);
            List<string> s = new List<string>();
            List<string> list = Program.DFS(g.Vertices[0], s);
            Assert.Equal(3, list.Count);
            Assert.Contains("a", list);
            Assert.Contains("b", list);
            Assert.Contains("c", list);
        }
        /// <summary>
        /// one node
        /// </summary>
        [Fact]
        public void dfsone()
        {
            Graph g = new Graph();
            Vertex v1 = g.AddNode("a");
            g.AddEdge(v1, v1, 3);

            List<string> s = new List<string>();
            List<string> list = Program.DFS(g.Vertices[0], s);
            Assert.True(list.Count==1);
            Assert.True(list[0] == "a");
        }
    }
}
