using System;
using Xunit;
using breadth_first_traversal;
using System.Collections.Generic;

namespace BreathfirstTDD
{
    public class UnitTest1
    {
        [Fact]
        public void candotraversal()
        {
            Tree tr =Program.GetATree();

           List<TreeNode> list=Program. Breathfirst(tr.Root);

            Assert.True( list[0].Val==400);

        }

        [Fact]
        public void candoBreadthfirst()
        {
            Tree tr = Program.GetATree();

            List<TreeNode> list = Program.Breathfirst(tr.Root);

            Assert.True(list[1].Val == 50);

        }

        [Fact]
        public void canBreadthfirst()
        {
            Tree tr = Program.GetATree();

            List<TreeNode> list = Program.Breathfirst(tr.Root);

            Assert.True(list[7].Val == 73);

        }
    }
}
