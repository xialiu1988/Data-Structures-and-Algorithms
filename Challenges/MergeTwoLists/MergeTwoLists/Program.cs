using System;
using LinkedList.Classes;

namespace MergeTwoLists
{
    public class Program
    {
       public static void Main(string[] args)
        {
         
            LList list1 = new LList();
            list1.Insert(2);
            list1.Insert(4);
            list1.Insert(6);
            list1.print();
            LList list2 = new LList();
            list2.Insert(7);
            list2.Insert(79);
            list2.Insert(9);
            list2.Insert(39);
            list2.print();
            Console.WriteLine("++++++++++++++++++++++");
            MergeTwoLists(list1, list2);
        
        }

        public static void MergeTwoLists(LList list1,LList list2)
        {
           list1.Current = list1.Head;
            list2.Current = list2.Head;


            int counter1 = 0;
            int counter2 = 0;

            while (list1.Current.Next != null)
            {
                list1.Current =list1.Current.Next;
                counter1++;
            }

            counter1++;



            while (list2.Current.Next != null)
            {
                list2.Current = list2.Current.Next;
                counter2++;
            }

            counter2++;

            list1.Current = list1.Head;
            list2.Current = list2.Head;

            while (counter1>counter2&&list1.Current.Next!=null)
            {
                Node temp = list1.Current.Next;
                list1.Current.Next = list2.Current;
                list1.Current = list1.Current.Next;
                list2.Current = list2.Current.Next;
                list1.Current.Next = temp;
                list1.Current = list1.Current.Next;
                //  temp = list1.Current.Next;
                //list1.Current.Next = temp;
            }

           

            while (counter1 == counter2&&list2.Current.Next!=null){

                Node temp = list1.Current.Next;
                list1.Current.Next = list2.Current;
                list1.Current = list1.Current.Next;
                list2.Current = list2.Current.Next;
                list1.Current.Next = temp;
                list1.Current = list1.Current.Next;


            }
            list1.Current.Next = list2.Current;
            list1.Current = list1.Current.Next;





            while(counter1<counter2 && list1.Current.Next != null)
            {
              Node temp = list1.Current.Next;
                list1.Current.Next = list2.Current;
                list1.Current = list1.Current.Next;
                list2.Current = list2.Current.Next;
                list1.Current.Next = temp;
                list1.Current = list1.Current.Next;

            }
   
            list1.print();
        }
    }
}
