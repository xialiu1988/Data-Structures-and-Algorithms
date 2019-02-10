using System;
using System.Collections.Generic;
using System.Text;

namespace SumOddNum_BST
{
   public class Treenode
    {
        public int Value { get; set; }
        public Treenode LeftChild { get; set; }
        public Treenode RightChild { get; set; }
        public Treenode(int val)
        {
            Value = val;
            LeftChild = null;
            RightChild = null;
        }
    }
}
