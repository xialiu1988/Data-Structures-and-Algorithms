using System;
using Xunit;
using tree_intersection;
using System.Collections.Generic;

namespace TreeIntersectionTDD { 
    public class UnitTest1
    {/// <summary>
    /// have one common value node 
    /// </summary>
        [Fact]
        public void cantesttwobt()
        {
            Tree tr1 = new Tree();
            tr1.add(3);
            tr1.add(5);
            Tree tr2 = new Tree();
            tr2.add(5);

          HashSet<int> res=  Program.treeIntersection(tr1.Root, tr2.Root);
            
            Assert.True(res.Count == 1);
           bool b= res.Contains(5);
            Assert.True(b);

        }
        /// <summary>
        /// have same value nodes but diffenrent order
        /// </summary>
        [Fact]
        public void cantesttwotrees()
        {
            Tree tr1 = new Tree();
            tr1.add(31);
            tr1.add(51);
            Tree tr2 = new Tree();
            tr2.add(51);
            tr2.add(31);

           HashSet<int> res = Program.treeIntersection(tr1.Root, tr2.Root);
            Assert.True(res.Count == 2);
            bool b = res.Contains(51);
            bool b2 = res.Contains(31);
            Assert.True(b);
            Assert.True(b2);

        }

        /// <summary>
        /// dont have any common value nodes
        /// </summary>
        [Fact]
        public void cantesttwotree()
        {
            Tree tr1 = new Tree();
            tr1.add(31);
            tr1.add(51);
            Tree tr2 = new Tree();
            tr2.add(1);
            tr2.add(11);

            HashSet<int> res = Program.treeIntersection(tr1.Root, tr2.Root);
            Assert.True(res.Count == 0);
  
        }
    }
}
