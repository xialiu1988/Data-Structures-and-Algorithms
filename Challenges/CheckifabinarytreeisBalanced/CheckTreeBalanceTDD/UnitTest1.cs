using System;
using Xunit;
using CheckifabinarytreeisBalanced;

namespace CheckTreeBalanceTDD
{
    public class UnitTest1
    {
        [Fact]
        public void NullTreeIsBalanced()
        {
            Tree tr = new Tree();
            bool boo = Program.IsBinaryTreeBalanced(tr.Root);
            Assert.True(boo);
        }
        /// <summary>
        /// only has root is balanced 
        /// </summary>
        [Fact]
        public void TreeIsBalanced()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(7);
            bool boo = Program.IsBinaryTreeBalanced(tr.Root);
            Assert.True(boo);
        }
        /// <summary>
        /// unbalanced, cuz root is 
        /// missing a leftchild
        /// </summary>
        [Fact]
        public void checkTreeIsunBalanced()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(4);
            tr.Root.RightChild = new TreeNode(4);
   

            bool boo = Program.IsBinaryTreeBalanced(tr.Root);
            Assert.False(boo);
        }
    }
}
