using System;
using Xunit;
using CalculateHeightOfBinaryTree;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(3);
            tr.Root.LeftChild = new TreeNode(5);
            tr.Root.RightChild = new TreeNode(15);
            int res = Program.CalculateBinaryTreeHeight(tr.Root);
            Assert.Equal(2, res);

        }


        [Fact]
        public void Test2()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(3);
            int res = Program.CalculateBinaryTreeHeight(tr.Root);
            Assert.Equal(1, res);

        }

        [Fact]
        public void Test3()
        {
            Tree tr = new Tree();

            int res = Program.CalculateBinaryTreeHeight(tr.Root);
            Assert.Equal(0, res);

        }
    }
}
