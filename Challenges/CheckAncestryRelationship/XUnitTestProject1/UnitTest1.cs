using System;
using Xunit;
using CheckAncestryRelationship;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(4);
            tr.Root.LeftChild = new TreeNode(5);
            bool b = Program.IsAncestor(4, 5, tr.Root);//4 is ancestor of 5
            Assert.True(b);

        }


        [Fact]
        public void cancheckrelationship()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(4);
            tr.Root.LeftChild = new TreeNode(5);
            bool b = Program.IsAncestor(5, 4, tr.Root);//5 is not the ancestor of 4
            Assert.False(b);

        }

        [Fact]
        public void cancheckNOtAncestryrelationship()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(4);
            tr.Root.LeftChild = new TreeNode(5);
            bool b = Program.IsAncestor(5, 45, tr.Root);//45 is  not even exsited in this tree
            Assert.False(b);

        }
    }
}
