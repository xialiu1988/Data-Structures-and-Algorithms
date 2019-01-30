using System;
using System.Collections;
using System.Collections.Generic;


namespace breadth_first_traversal
{
   public class Program
    {
       
        public  static void Main(string[] args)
        {

            Tree tr = GetATree();

          List<TreeNode>list=Breathfirst(tr.Root);
            Console.WriteLine();

        }


        public static Tree GetATree()
        {

            Tree tr = new Tree();
            tr.Add(400);
            tr.Add(50);
            tr.Add(20);
            tr.Add(132);
            tr.Add(73);
            tr.Add(507);
            tr.Add(17);
            tr.Add(700);

            return tr;

        }



        public static List<TreeNode> Breathfirst(TreeNode root)
        {
            List<TreeNode> list = new List<TreeNode>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int counter = 1;

          // while loop to make sure the queue is not empty,print out the nodes'vlaues,if empty stop

            while (q.Count>0)
            {
            
                TreeNode n = (q.Dequeue());
                Console.WriteLine(counter+":"+n.Val);
                list.Add(n);
                counter++;
                if (n.LeftChild != null)
                { q.Enqueue(n.LeftChild);
           
                }
                if (n.RightChild != null)
                {
                    q.Enqueue(n.RightChild);
   
                }
              
            }

            return list;


        }


    }
}
