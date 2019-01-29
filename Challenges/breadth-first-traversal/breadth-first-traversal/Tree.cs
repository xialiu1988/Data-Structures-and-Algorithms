using System;
using System.Collections.Generic;
using System.Text;

namespace breadth_first_traversal
{
   public class Tree
    {
        public TreeNode Root { get; set; }

        public Tree()
        {
            Root = null;
        }


       private TreeNode AddTraversive(TreeNode node,int val)
        {
            if (node == null)
            {
                return new TreeNode(val);
            }

            if (val < node.Val)
            {
                node.LeftChild = AddTraversive(node.LeftChild, val);
            }
            else if (val > node.Val)
            {
                node.RightChild = AddTraversive(node.RightChild, val);
            }
            else
            {
                return node;
            }
            return node;


        }

        public void Add(int val)
        {
            Root = AddTraversive(Root, val);
        }



    }
}
