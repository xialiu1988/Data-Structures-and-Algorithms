using System;
using System.Collections.Generic;
using System.Text;

namespace find_maximum_value_binary_tree
{
   public class Tree
    {
        public TreeNode Root { get; set; }

        public Tree()
        {
            Root = null;
        }
  
          /// <summary>
          /// travesal from top to bottom
          /// </summary>
          /// <param name="node"></param>          

        public void preOrder(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                preOrder(node.LeftChild);
                preOrder(node.RightChild);
            }

        }

    

      

    }
}
