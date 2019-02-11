using System;

namespace CalculateHeightOfBinaryTree
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree tr = GetATree();
            tr.preorder(tr.Root);
            int res = CalculateBinaryTreeHeight(tr.Root);
            Console.WriteLine($"the tree 's  height is {res} ");
        }

        public static Tree GetATree()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(6);
            tr.Root.LeftChild = new TreeNode(23);
            tr.Root.RightChild = new TreeNode(3);
            tr.Root.LeftChild.LeftChild= new TreeNode(12);
            tr.Root.LeftChild.RightChild= new TreeNode(7);
            return tr;

        }


        public static int CalculateBinaryTreeHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int lheight = CalculateBinaryTreeHeight(root.LeftChild);
                int rheight = CalculateBinaryTreeHeight(root.RightChild);
                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else return ( rheight + 1);
            }

        }
    }
}
