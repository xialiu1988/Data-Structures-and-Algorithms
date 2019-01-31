using System;
using System.Collections;
using System.Collections.Generic;

namespace find_maximum_value_binary_tree
{
    public class Program
    {
        public static List<TreeNode> list = new List<TreeNode>();
        public static void Main(string[] args)
        {
            Tree tr = GetAtree();
            tr.preOrder(tr.Root);
            Console.WriteLine("======================");
            Console.WriteLine();

            //get the new list from GetAllValues;
            List<TreeNode> group = GetAllValues(tr.Root);

            int temp = 0;//set a temp value, everytime value larger than this,update it and it will be the maximum value in the end
            //for loop go through the list we get and find the biggest value
            for (int i = 0; i < group.Count; i++)
            {            
                if (list[i].Value > temp)
                {
                    temp = list[i].Value;
                }
            } 
            Console.WriteLine("The maximum value this tree is:"+ " "+ temp);

        }
        /// <summary>
        /// create a new tree
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// using recursive method to add all the nodess' value  to the list we created very beginning
        /// </summary>
        /// <param name="node"></param>
        /// <returns>a new list </returns>

        public static List<TreeNode> GetAllValues(TreeNode node)
        {

            if (node != null)
            {
                list.Add(node);

                GetAllValues(node.LeftChild);
                GetAllValues(node.RightChild);

            }
            return list;
        }
    }

}