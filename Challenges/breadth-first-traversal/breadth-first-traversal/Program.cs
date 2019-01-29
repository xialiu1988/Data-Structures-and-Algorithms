using System;
using System.Collections;
using System.Collections.Generic;

namespace breadth_first_traversal
{
   public class Program
    {
       
        public  static void Main(string[] args)
        {

            Tree tr = GetATree();

            Breathfirst(tr.Root);
            Console.WriteLine();

        }


        public static Tree GetATree()
        {

            Tree tr = new Tree();
            tr.Add(400);
            tr.Add(50);
            tr.Add(20);
            tr.Add(132);
            tr.Add(73);
            tr.Add(507);
            tr.Add(17);
            tr.Add(700);

            return tr;

        }


        public static void Breathfirst(TreeNode root)
        {
            int h = height(root);

            for (int i = 1; i <= h; i++)
            {
                printthenthLevel(root, i);
            }
        }

        public static void printthenthLevel(TreeNode root,int level)
        {
            if (root == null)
            {
                return;
            }

            if (level == 1)
            {
                Console.Write(root.Val + " ");
            }
            else if (level > 1)
            {
                printthenthLevel(root.LeftChild, level - 1);
                printthenthLevel(root.RightChild, level - 1);
            }
        }

      

        public static int height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
           
                int lheight = height(root.LeftChild);
                int rheight = height(root.RightChild);

   
                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }

    }
}
