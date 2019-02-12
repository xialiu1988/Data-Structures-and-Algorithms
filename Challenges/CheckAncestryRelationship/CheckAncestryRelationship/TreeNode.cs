using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAncestryRelationship
{
   public class TreeNode
    { public int Val { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int val)
        {
            Val = val;
        }
    }
}
