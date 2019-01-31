using System;
using System.Collections;
using System.Collections.Generic;

namespace find_maximum_value_binary_tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree tr = GetAtree();
            tr.preOrder(tr.Root);
            Console.WriteLine("======================");
            Console.WriteLine();
            int max = 0;
            GetMax(tr.Root);
            //  Console.WriteLine("The maximum value in the tree is:" + " " + b);
        }

        public static Tree GetAtree()
        {
            Tree tr = new Tree();
            tr.Root = new TreeNode(4);
            tr.Root.LeftChild = new TreeNode(100);
            tr.Root.RightChild = new TreeNode(27);
            tr.Root.LeftChild.LeftChild = new TreeNode(48);
            tr.Root.LeftChild.RightChild = new TreeNode(330);
            tr.Root.RightChild.LeftChild = new TreeNode(201);
            tr.Root.RightChild.RightChild = new TreeNode(43);

            return tr;
        }


        public static void GetMax(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            
            while (s!=null)
            {
                TreeNode nn = s.Pop();
                if (nn.LeftChild.Value > nn.Value)
                {
                    s.Push(nn.LeftChild);
                }
                else if (nn.RightChild.Value > nn.Value)
                {
                    s.Push(nn.RightChild);
                }
            }

            Console.WriteLine(s.Peek());

        }

    }
}

