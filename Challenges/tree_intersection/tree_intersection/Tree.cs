using System;
using System.Collections.Generic;
using System.Text;

namespace tree_intersection
{
   public class Tree
    {
        public TreeNode Root { get; set; }
        public Tree()
        {
            Root = null;
        }

        public TreeNode addrecursive(TreeNode node,int val)
        {
            if (node == null)
            {
                return new TreeNode(val);
            }

            if (val < node.Value)
            {
               node.LeftChild = addrecursive(node.LeftChild, val);
            }
            else if (val > node.Value)
            {
                node.RightChild = addrecursive(node.RightChild, val);
            }
            else
            {
                return node;
            }
            return node;
        }
        

        public void add(int val)
        {
            Root = addrecursive(Root, val);
        }
        /// <summary>
        /// output the tree
        /// </summary>
        /// <param name="node"></param>
        public void preOrder(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                preOrder(node.LeftChild);
                preOrder(node.RightChild);
            }

        }




    }
}
