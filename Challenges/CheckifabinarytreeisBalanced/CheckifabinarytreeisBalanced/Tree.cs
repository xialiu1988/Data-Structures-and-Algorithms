using System;
using System.Collections.Generic;
using System.Text;

namespace CheckifabinarytreeisBalanced
{
  public  class Tree
    {
        public  TreeNode Root { get; set; }
        public Tree()
        {
            Root = null;
        }
           

        public void PreOrder(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Val);
                PreOrder(node.LeftChild);
                PreOrder(node.RightChild);
            }
        }

    }
}
