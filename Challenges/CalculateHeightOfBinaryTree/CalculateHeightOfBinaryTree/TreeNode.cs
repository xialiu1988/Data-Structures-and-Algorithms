using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateHeightOfBinaryTree
{
   public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode(int val)
        {
            Value = val;
        }
    }
}
