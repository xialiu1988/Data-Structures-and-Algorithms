using System;

namespace Tree
{
   public class Program
    {
       public static void Main(string[] args)
        {
           
            BinarySearchTree bt= createTree();
           bool a= bt.contains(38);
            Console.WriteLine("this contains 38");
            Console.WriteLine(a);
            bool b = bt.contains(2);
            Console.WriteLine("this Does not contain  2");
            Console.WriteLine(b);


            Console.WriteLine("========================");
            BinaryTree bb = new BinaryTree();
            bb.createTree();
            Console.WriteLine("========PreOrder=======");
            bb.preOrder(bb.Root);
            Console.WriteLine("========inOrder=========");
            bb.inOrder(bb.Root);
            Console.WriteLine();
            Console.WriteLine("=====postOrder=======");
            bb.postOrder(bb.Root);


        }



        public static BinarySearchTree createTree()
        {
            BinarySearchTree bt = new BinarySearchTree();

            bt.Add(5);
            bt.Add(3);
            bt.Add(7);
            bt.Add(38);
            bt.Add(93);
            bt.Add(300);
            bt.Add(100);
            bt.Add(13);
            bt.Add(1);
            return bt;
        }
        
    }
}
