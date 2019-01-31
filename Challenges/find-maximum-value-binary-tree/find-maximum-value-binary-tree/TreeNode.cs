using System;
using System.Collections.Generic;
using System.Text;

namespace find_maximum_value_binary_tree
{
   public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode(int value)
        {
            Value = value;
        }
    }
}
