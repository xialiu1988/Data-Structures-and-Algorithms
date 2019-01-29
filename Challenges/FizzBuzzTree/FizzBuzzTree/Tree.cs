using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
   public class Tree
    {
        public TreeNode  Root { get; set; }




        public Tree( )
        {
            Root = null;

        }

        public Tree(TreeNode node)
        {
            Root = node;

        }
       


        public List<Object> traverseTree(TreeNode node, List<Object> values)
        {
            values.Add(node.Value);
            if (node.LeftChild != null)
            {
                traverseTree(node.LeftChild, values);
            }
            if (node.RightChild != null)
            {
                traverseTree(node.RightChild, values);
            };
            return values;
        }

        public Object[] preOrder()
        {
            List<Object> values = new List<Object>();
            if (Root != null)
            {
                traverseTree(Root, values);
            }
            return values.ToArray();
        }






    }
}
