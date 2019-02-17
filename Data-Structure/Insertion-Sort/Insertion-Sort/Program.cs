using System;
using System.Collections.Generic;

namespace Insertion_Sort
{
   public  class Program
    {
       public static void Main(string[] args)
        {
            int[] arr = { 7,2,1,40,22};
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("====INsertion======SORTTTTTT=============");
           int[] res= InsertionSort(arr);
            for(int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine();
            Console.WriteLine("====Merge======SORTTTTTT=============");
            MergeSort(arr);
        }
        /// <summary>
        ///MergeSort
        /// </summary>
        /// <param name="arr"></param>
        public static void MergeSort(int[] arr)
        {
            int begin =0 ;
            int end = arr.Length - 1;
            int mid = end / 2;
           
            int t = mid+1;
          
            while (begin < mid)
            {
                int i = begin + 1;
                while (i <= mid)
                {
                    if (arr[i] > arr[begin])
                    {
                        i++;
                    }
                    else
                    {
                        int temp = 0;
                        temp = arr[begin];
                        arr[begin] = arr[i];
                        arr[i] = temp;
                        i++;

                    }
                }
                begin++;
            }

            while (t< end)
            {
                int j = t + 1;
                while ( j<= end)
                {
                    if (arr[j] > arr[t])
                    {
                        j++;
                    }
                    else
                    {
                        int temp = 0;
                        temp = arr[t];
                        arr[t] = arr[j];
                        arr[j] = temp;
                        j++;

                    }
                }
                t++;
            }



            List<int> list = new List<int>();


            int h = 0;
            int k = mid + 1;
            while (h <= mid&& k < arr.Length)
            { 
                    if (arr[h] > arr[k])
                    {
                        list.Add(arr[k]);
                        k++;
                    }
                    else if(arr[h]<arr[k])
                    {
                        list.Add(arr[h]);
                        h++;
                    }
                }

            while (h <= mid)
            {
                list.Add(arr[h]);
                h++;
            }
            while (k < arr.Length)
            {
                list.Add(arr[k]);
                k++;
            }
        
     
       //output the list with sorted values
            for (int ii = 0; ii <list.Count; ii++)
            {
                Console.WriteLine(list[ii]);
            }
        }


        /// <summary>
        /// Insert sort.
        /// </summary>
        /// <param name="arr"></param>

        public static int[] InsertionSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                return arr;

            }
            for(int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(arr, j - 1, j);
                    }
                    else
                    {
                        break;
                    }
                }
            }


            return arr;

        }


        private static void Swap(int[] arr, int i,int j)
        {
            int temp = 0;
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
