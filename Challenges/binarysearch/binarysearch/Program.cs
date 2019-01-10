using System;

namespace binarysearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // int[] nums = { 4, 8, 15, 16, 23, 42 };
            //int target = 15;

            
            int[] nums = { 11, 22, 33, 44, 55, 66, 77 };
            int key = 99;

            int index= BinarySearch(nums, key);
            Console.WriteLine(index);
        }

        public static int BinarySearch(int[] arr,int key)
        {
            int leftIndex=0;
            int rightIndedx =arr.Length - 1;

            while (leftIndex <= rightIndedx)
            {
                int middle = (leftIndex+ rightIndedx) / 2;
                if (key == arr[middle])
                {
                    return middle;
                }
                else if (key > arr[middle])
                {
                    leftIndex = middle + 1;
                }
                else 
                {
                    rightIndedx = middle - 1;
                }
            }
            return -1;
        }




    }
}
