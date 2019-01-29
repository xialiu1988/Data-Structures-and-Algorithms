﻿using System;

namespace FizzBuzzTree
{
   public class Program
    {
       public static void Main(string[] args)
        {
            GetaTree();
         

        }

        public static void GetaTree()
        {
            Tree  tr = new Tree();
            tr.Root = new TreeNode(9);
            tr.Root.LeftChild = new TreeNode(3);
            tr.Root .RightChild= new TreeNode(15);
            tr.Root.LeftChild.LeftChild = new TreeNode(20);
            tr.Root.LeftChild.RightChild = new TreeNode(18);
            tr.Root.RightChild.LeftChild = new TreeNode(14);
            tr.Root.RightChild.RightChild = new TreeNode(4);
            Print(tr.preOrder());
            Console.WriteLine("++++++++++++++++");
            FizzBuzzTree(tr.Root);
            Print(tr.preOrder());
        }

        public static void FizzBuzzTree(TreeNode node)
        {

            if (node != null)
            {

                if(Convert.ToInt32(node.Value) % 15 == 0)
                {
                    node.Value = "FizzBuzz";
                }
                else if(Convert.ToInt32(node.Value) % 5 == 0)
                {
                    node.Value = "Buzz";
                }
                else if (Convert.ToInt32(node.Value) % 3 == 0)
                {
                    node.Value = "Fizz";
                }
                else
                {
                    node.Value = node.Value;
                }

                FizzBuzzTree(node.LeftChild);
                FizzBuzzTree(node.RightChild);
            }


        }
        public static void Print(Object[] tree)
        {
            foreach (Object value in tree)
            {
                Console.WriteLine($"{value}");
            }

        }


    }
}