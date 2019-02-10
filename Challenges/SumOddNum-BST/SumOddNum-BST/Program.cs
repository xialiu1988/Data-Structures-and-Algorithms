using System;

namespace SumOddNum_BST
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            Tree tree = GetATree();
            tree.PreOrder(tree.Root);
           int res= getsum(tree.Root, 0);
            Console.WriteLine($"The sum of odd numbers in this tree is {res}");
        }

        /// <summary>
        /// create a new binary search tree, insert several nodes with values
        /// </summary>
        /// <returns></returns>
        public static Tree GetATree()
        {
            
            Tree tr = new Tree();
           tr.Add(49);
            tr.Add(2);
            tr.Add(12);
          tr.Add(99);
            tr.Add(23);
            return tr;
        }

        /// <summary>
        /// recursive methods,pass in node with the sum. sum will be 0 at very beginning
        /// </summary>
        /// <param name="node"></param>
        /// <param name="sum"></param>
        /// <returns>sum</returns>
        public static int SumOfOdd(Treenode node,int sum)
        {

            if (node == null)
            {
                return sum;
            }
            if (node.Value % 2 != 0)
            {
                sum += node.Value;
            }

             sum= SumOfOdd(node.LeftChild, sum);
            sum= SumOfOdd(node.RightChild, sum);
            return sum;
        }

        /// <summary>
        /// get sum of  odd numbers 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns>sum</returns>
        public static int getsum(Treenode root,int sum)
        { 
            sum = SumOfOdd(root, sum);
            return sum;

        }


    }
}
