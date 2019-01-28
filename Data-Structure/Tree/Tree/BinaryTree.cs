using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {
      public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// just create a binary tree here.Give it several nodes
        /// </summary>
        public void createTree()
        {
            Root = new Node(3);
            Root.LeftChild = new Node(59);
            Root.RightChild = new Node(8);
            Root.LeftChild.LeftChild = new Node(99);
            Root.LeftChild.RightChild = new Node(2);
            Root.RightChild.LeftChild = new Node(19);
            Root.RightChild.RightChild = new Node(3);
        }

        
        /// <summary>
        /// preOrder from root to the bottom(leaf)
        /// </summary>
        /// <param name="node"></param>
        public void preOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                preOrder(node.LeftChild);
                preOrder(node.RightChild);
            }

        }
        /// <summary>
        /// inorder root comes when left part has done
        /// </summary>
        /// <param name="node"></param>
       
        public void inOrder(Node node)
        {
            if (node != null)
            {
                inOrder(node.LeftChild);
                Console.Write(node.Value);
                inOrder(node.RightChild);
            }

        }
        /// <summary>
        /// post order root comes last
        /// </summary>
        /// <param name="node"></param>

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
