using System;

namespace FizzBuzzTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree tr = GetaTree();
            Object[] trr = tr.preOrder();
            foreach (Object value in trr)
            {
                Console.WriteLine($"{value}");
            }

            Console.WriteLine("++++++++++++++++");

            FizzBuzzTree(tr.Root);
         

        }

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

        public static void FizzBuzzTree(TreeNode node)
        {

            if (node != null)
            {

                if (Convert.ToInt32(node.Value) % 15 == 0)
                {
                   Console.WriteLine( "FizzBuzz");
                }
                else if (Convert.ToInt32(node.Value) % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (Convert.ToInt32(node.Value) % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(node.Value);
                }

                FizzBuzzTree(node.LeftChild);
                FizzBuzzTree(node.RightChild);
            }

  
        }



    }
}