using System;
using System.Collections.Generic;

namespace combinationsbalancedparentheses
{
   public class Program
    {
       public static void Main(string[] args)
        {
           string[] res= Getallcombinations(1);
            for(int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res);
            }
           
        }

        public static string[] Getallcombinations(int n)
        {

            Stack<string> left = new Stack<string>();

        }
    }
}
