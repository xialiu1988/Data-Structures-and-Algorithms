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
    }
}
