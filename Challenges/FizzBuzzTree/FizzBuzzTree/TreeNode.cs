using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class TreeNode
    {
        public Object Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
    

        public TreeNode(Object d){
            Value = d;
            LeftChild = null;
            RightChild = null;

            }


    }
}
