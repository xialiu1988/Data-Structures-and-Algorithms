using System;

namespace arrayshift
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           int[] array = { 2, 4, 6, 8 };
            //int[] array = { 4, 8, 15, 28,42 };
            Console.Write("[");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.Write($"{array[array.Length-1]}");
            Console.WriteLine("]");

            int val = 5;
            //call Arrayshift function and return a new array
            int[] newarray = ArrayShift(array, val);
           
            //go through the new array and print every item on the screen
            Console.Write("[");
            for(int i = 0; i < newarray.Length-1; i++)
            {
                Console.Write($"{newarray[i]},");
            }
            Console.Write($"{newarray[newarray.Length - 1]}");
            Console.Write("]");
        }

    public  static int[] ArrayShift(int[] array, int val){


            int[] newArray = new int[array.Length + 1];

            if(array.Length % 2 == 0)
            {
                int middlePointindex = array.Length * 1 / 2;

                for(int i = 0; i < newArray.Length; i++)
                {
                    if (i < middlePointindex)
                    {
                        newArray[i] = array[i];
                    }
                    else if(i == middlePointindex)
                    {
                        newArray[i] = val;
                    }
                    else
                    {
                        newArray[i] = array[i - 1];
                    }


                }
                return newArray;

            }
            else
            {
                int middlePointindex = (array.Length+1)* 1 / 2;

                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i < middlePointindex)
                    {
                        newArray[i] = array[i];
                    }
                    else if (i == middlePointindex)
                    {
                        newArray[i] = val;
                    }
                    else
                    {
                        newArray[i] = array[i - 1];
                    }


                }
                return newArray;

            }


        }


    }
}
