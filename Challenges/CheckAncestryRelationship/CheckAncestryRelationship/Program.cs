using System;
using System.Collections.Generic;

namespace CheckAncestryRelationship
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Tree tr = GetATree();
            bool boo = IsAncestor(7, 12, tr.Root);

            Console.WriteLine($"are they ancestry relationship:  {boo}");
        }


        /// <summary>
        /// create a tree
        /// </summary>
        /// <returns></returns>
        public static Tree GetATree()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(67);
            tr.Root.LeftChild = new TreeNode(7);
            tr.Root.RightChild = new TreeNode(1);
            tr.Root.LeftChild.LeftChild = new TreeNode(12);
            tr.Root.LeftChild.RightChild = new TreeNode(31);
            return tr;
        }



        public static bool IsAncestor(int A, int B, TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                TreeNode n = q.Dequeue();
               if(n.Val == A)
                {
                    if (n.LeftChild != null && n.LeftChild.Val == B) return true;
                   else if (n.RightChild != null && n.RightChild.Val == B) return true;
                   else return false;
                }
                q.Enqueue(n.LeftChild);
                q.Enqueue(n.RightChild);
            }
            return false;

        }
    }
}
