using System;
using Xunit;
using find_maximum_value_binary_tree;
using System.Collections.Generic;

namespace MaximumTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMax()
        {

            Tree tr = new Tree();
            tr.Root = new TreeNode(54);
         
            Assert.Equal(54, Program.getMax(tr));
        }

        [Fact]
        public void CanFindValue()
        {
            Tree tr2 = new Tree();
            tr2.Root = new TreeNode(54);
            tr2.Root.LeftChild = new TreeNode(4);
            tr2.Root.LeftChild.LeftChild = new TreeNode(10);
            int bb = Program.getMax(tr2);
            Assert.True(bb == 54);
        }

        [Fact]
        public void CangetValue()
        {
            Tree tr3 = new Tree(); 
            tr3.Root = new TreeNode(4);          
            Assert.Equal(4, Program.getMax(tr3));

        }
    }
}
