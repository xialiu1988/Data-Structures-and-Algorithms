using System;
using System.Collections.Generic;

namespace tree_intersection
{
   public  class Program
    {
      public static void Main(string[] args)
        {
            Tree tr1 = new Tree();
            tr1.add(64);
            tr1.add(9);
            tr1.add(10);
            tr1.add(14);
            tr1.add(33);
            tr1.add(18);

            Tree tr2 = new Tree();
            tr2.add(64);
            tr2.add(10);
            tr2.add(74);
            tr2.add(23);
            tr2.add(18);
            tr1.preOrder(tr1.Root);
            Console.WriteLine("===================");
            tr2.preOrder(tr2.Root);
            Console.WriteLine("===================");
            Console.WriteLine("===================");
       List<int> res=   treeIntersection(tr1.Root, tr2.Root);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// compare with two lists and return a list with all the common nodes'value
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public static List<int> treeIntersection(TreeNode root1, TreeNode root2)
        {
            List<int> res = new List<int>();
          List<int> raw1 = new List<int>();
           List<int> raw2 = new List<int>();
           List<int> list = filloutlist(root1,raw1);

            List<int> list2 = filloutlist(root2,raw2);
          
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list2.Count; j++)
                {
                    if (list[i] == list2[j])
                    {
                        res.Add(list[i]);
                    }
                }
            }


           
            return res;
        }
        /// <summary>
        /// fill out the list with tree nodes' value
        /// </summary>
        /// <param name="node"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> filloutlist(TreeNode node,List<int> list)
        {
           
            if (node != null)
            {
                list.Add(node.Value);
            }
            if (node.LeftChild != null)
            {
                filloutlist(node.LeftChild,list);
            }
            if (node.RightChild != null)
            {
                filloutlist(node.RightChild,list);
            }
            return list;

        }


    }
}
