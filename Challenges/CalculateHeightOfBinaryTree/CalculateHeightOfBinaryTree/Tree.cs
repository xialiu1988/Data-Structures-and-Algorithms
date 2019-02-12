using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateHeightOfBinaryTree
{
    public class Tree
    {
        public TreeNode Root { get; set; }
        public Tree()
        {
            Root = null;
        }


     


        public void preorder(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                preorder(node.LeftChild);
                preorder(node.RightChild);
            }
        }

    }
}
