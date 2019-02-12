using System;
using System.Collections.Generic;

namespace CheckifabinarytreeisBalanced
{
    public class Program
    {
      public static void Main(string[] args)
        {
            Tree tr = GetATree();
            tr.PreOrder(tr.Root);
            bool boo = IsBinaryTreeBalanced(tr.Root);
            Console.WriteLine($"Is this balanced?  {boo}");
        }

        /// <summary>
        /// creat a new tree
        /// </summary>
        /// <returns></returns>
        public static Tree GetATree()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(5);
            tr.Root.LeftChild = new TreeNode(10);
            tr.Root.RightChild = new TreeNode(87);
           tr.Root.LeftChild.LeftChild = new TreeNode(7);
            return tr;
        }

       public static bool IsBinaryTreeBalanced(TreeNode root)
        {if (root == null) return true;//null tree is a balanced BT
            int lheight = treeHeight(root.LeftChild);
            int rheight = treeHeight(root.RightChild);
            if (lheight != rheight) return false;

            else return IsBinaryTreeBalanced(root.LeftChild) && IsBinaryTreeBalanced(root.RightChild);
        }

        /// <summary>
        /// get tree height
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static int treeHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int lheight = treeHeight(node.LeftChild);
            int rheight = treeHeight(node.RightChild);
            return lheight > rheight ? (lheight + 1) : (rheight + 1);


        }


    }
}
