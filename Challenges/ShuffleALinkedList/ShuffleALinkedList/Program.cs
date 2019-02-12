using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleALinkedList
{
   public class Program
    {
       public static void Main(string[] args)
        {
            LList l = GetAlist();
            l.print();
           // Console.WriteLine(l.counter);
            Console.WriteLine("====================");
            ShuffleALinkedList(l);           
        }


        public static LList GetAlist()
        {
           
            LList l = new LList();
            l.Head = new Node(6);
           l.counter++;
            l.Insert(9);       
            l.Insert(20);        
            l.Insert(17);
            l.Insert(23);
            l.Insert(2);
            return l;
            
        }

        public static void ShuffleALinkedList(LList l)
        {
            int[] arr = new int[l.counter];
            l.Current = l.Head;
           for(int i = 0; i < l.counter; i++)
            {
                arr[i] = l.Current.Value;
                l.Current = l.Current.Next;
            }
         
       
           for(int i = 0; i < l.counter / 2; i++)
            {
                int temp = 0;
                temp = arr[i];
                arr[i] = arr[l.counter - i - 1];
                arr[l.counter - i - 1] = temp;
            }



           for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} =>");

            }
            Console.WriteLine("null");
            }
          


        }



    }

