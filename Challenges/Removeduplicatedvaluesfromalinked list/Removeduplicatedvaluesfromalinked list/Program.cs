using System;
using System.Collections.Generic;

namespace Removeduplicatedvaluesfromalinked_list
{
   public class Program
    {
      public  static void Main(string[] args)
        {         
            Llist newl = GetAList();
            newl.print();
            Console.WriteLine("=============================");
            RemoveDuplicates(newl);
        }

        public static Llist GetAList()
        {

            Llist l = new Llist();
            l.Head = new Node(3);
            l.Insert(5);
            l.Insert(20);
            l.Insert(13);
            l.Insert(5);
            l.Insert(9);
            l.Insert(5);
            return l;
        }
         
        public static void RemoveDuplicates(Llist l)
        {
            List<int> list = new List<int>();
            l.Curr = l.Head;
            while (l.Curr.Next != null)
            {
                if (list.Contains(l.Curr.Val))
                {
                    l.Curr = l.Curr.Next;
                }
                else
                {
                    list.Add(l.Curr.Val);
                }
            }

            if (list.Contains(l.Curr.Val))
            {
                for (int i = 0; i < list.Count-1; i++)
                {
                    Console.Write($"{list[i]} =>");
                }
                Console.WriteLine(list[list.Count - 1]);
            }

            else
            {
                list.Add(l.Curr.Val);
                for (int i = 0; i < list.Count-1; i++)
                {
                    Console.Write($"{list[i]} =>");
                }
                Console.WriteLine(list[list.Count - 1]);

            }

        }

    }
}
