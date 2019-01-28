using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
   public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }
        /// <summary>
        /// using recursive to add value,everytime compare the value to leftchild and right child
        /// </summary>
        /// <param name="curr"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        private Node addRecursive(Node curr, int val)
        {
            if (curr == null)
            {
                return new Node(val);
            }
            if (val < curr.Value)
            {
                curr.LeftChild = addRecursive(curr.LeftChild, val);
            }

            else if (val > curr.Value)
            {
                curr.RightChild = addRecursive(curr.RightChild, val);
            }
            else
            {
                return curr;
            }
            return curr;


        }

        /// <summary>
        /// call recurisive method here
        /// </summary>
        /// <param name="val"></param>
        public void Add(int val)
        {
            Root = addRecursive(Root, val);

        }

        /// <summary>
        /// should be private, doesn't need to show public the process 
        /// </summary>
        /// <param name="curr"></param>
        /// <param name="val"></param>
        /// <returns></returns>
       private bool containsVal(Node curr,int val)
        {
            if (curr == null)
            {
                return false;
            }

            if (val == curr.Value)
            {
                return true;
            }
            return val < curr.Value ? containsVal(curr.LeftChild, val) : containsVal(curr.RightChild, val);
        }


        public bool contains(int val)
        {
            return containsVal(Root, val);
        }



        public void preOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                preOrder(node.LeftChild);
                preOrder(node.RightChild);
            }

        }


        public void inOrder(Node node)
        {
            if (node != null)
            {
                inOrder(node.LeftChild);
                Console.WriteLine(node.Value);
                inOrder(node.RightChild);
            }

        }


        public void postOrder(Node node)
        {
            if (node != null)
            {
                postOrder(node.LeftChild);
                postOrder(node.RightChild);
                Console.WriteLine(node.Value);
            }

        }




    }
}
