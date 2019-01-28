using System;
using Xunit;
using Tree;
namespace TreesTDD
{
    public class UnitTest1
    {  /// <summary>
    /// BinaryTree part tests
    /// </summary>
        [Fact]
        public void CanCreateATree()
        {
            BinaryTree bb = new BinaryTree();
            bb.createTree();
            Assert.Equal(3, bb.Root.Value);
        }

        [Fact]
        public void CanPreorderATree()
        {
            BinaryTree bb = new BinaryTree();
            bb.createTree();
            bb.preOrder(bb.Root);
            Assert.Equal(3, bb.Root.Value);
        }

        [Fact]
        public void CanInorderATree()
        {
            BinaryTree bb = new BinaryTree();
            bb.createTree();
            bb.inOrder(bb.Root);
    
        }
        [Fact]
        public void CanPostorderATree()
        {
            BinaryTree bb = new BinaryTree();
            bb.createTree();
            bb.postOrder(bb.Root);

        }

        /// <summary>
        /// BinarySearchTree part
        /// </summary>

        [Fact]
        public void CanAddvaluetoATree()
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.Add(5);
            Assert.True(bt.Root.Value==5);

        }
        [Fact]
        public void CanAddvalueATree()
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.Add(5);
            bt.Add(4);
            Assert.True(bt.Root.LeftChild.Value == 4);

        }

        [Fact]
        public void CanAddvalueTree()
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.Add(5);
            bt.Add(14);
            Assert.True(bt.Root.RightChild.Value == 14);

        }

        [Fact]
        public void DetermineContainsAvalue()
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.Add(5);
            bt.Add(14);
            Assert.True(bt.contains(14));

        }
        [Fact]
        public void DetermineNOtContainsAvalue()
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.Add(5);
            bt.Add(14);
            Assert.False(bt.contains(588));

        }
        [Fact]
        public void DetermineNOtContainsvalue()
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.Add(5);
            bt.Add(14);
            Assert.False(bt.contains(3));

        }
    }
}
