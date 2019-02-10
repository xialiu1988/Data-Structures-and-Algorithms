using System;
using System.Collections.Generic;
using System.Text;

namespace SumOddNum_BST
{
   public class Tree
    {
        public Treenode Root { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public Tree()
        {
            Root = null;
        }
        /// <summary>
        /// add node to a binary-search-tree,tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        private Treenode addRecursive(Treenode node,int val)
        {
            if (node == null)
            {
                return new Treenode(val);
            }

            if (val < node.Value)
            {
                node.LeftChild = addRecursive(node.LeftChild, val);
            }
            else if (val > node.Value)
            {
                node.RightChild = addRecursive(node.RightChild, val);
            }
            else
            {
                return node;
            }
            return node;

        }



        public void Add(int val)
        {
            Root = addRecursive(Root, val);
        }

        /// <summary>
        /// preoder -->output all the value
        /// </summary>
        public void PreOrder(Treenode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrder(node.LeftChild);
                PreOrder(node.RightChild);
               
            }
        }

    }
}
