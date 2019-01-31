using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzTree
{
    public class Program
    {/// <summary>
    /// creat a list to store the new tree after we change the value;
    /// </summary>
        public static List<TreeNode> list = new List<TreeNode>();

        public static void Main(string[] args)
        {
            Tree tr = GetaTree();
            Object[] trr = tr.preOrder();
            foreach (Object value in trr)
            {
                Console.WriteLine($"{value}");
            }

            Console.WriteLine("++++++++++++++++");

          List<TreeNode> groups= FizzBuzzTree(tr.Root);
            foreach (TreeNode nd in groups)
            {
                Console.WriteLine($" {nd.Value} ");
            }

        }
        /// <summary>
        /// create a tree
        /// </summary>
        /// <returns>tree with values</returns>
        public static Tree GetaTree()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(9);
            tr.Root.LeftChild = new TreeNode(3);
            tr.Root.RightChild = new TreeNode(15);
            tr.Root.LeftChild.LeftChild = new TreeNode(20);
            tr.Root.LeftChild.RightChild = new TreeNode(18);
            tr.Root.RightChild.LeftChild = new TreeNode(14);
            tr.Root.RightChild.RightChild = new TreeNode(4);
            return tr;
        }
        /// <summary>
        /// pass in a node and see if it meets any conditions inside the block,and change the value if the meet the condition
        /// </summary>
        /// <param name="node"></param>
        /// <returns>a list type of TreeNode objects with new values</returns>
        public static List<TreeNode> FizzBuzzTree(TreeNode node)
        {

            if (node != null)
            {
                
                    if ((int)node.Value % 15 == 0)
                    {
                        node.Value = "FizzBuzz";
                    }
                    else if ((int)node.Value% 5 == 0)
                    {
                        node.Value = "Buzz";
                    }
                    else if ((int)node.Value % 3 == 0)
                    {
                        node.Value = "Fizz";
                    }
                list.Add(node);

                if (node.LeftChild != null)
                {
                    FizzBuzzTree(node.LeftChild);
                }
                if (node.RightChild != null)
                {
                    FizzBuzzTree(node.RightChild);
                }


            }

            return list;
        }



    }
}