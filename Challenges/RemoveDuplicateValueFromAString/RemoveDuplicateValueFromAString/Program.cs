using System;
using System.Collections.Generic;

namespace RemoveDuplicateValueFromAString
{
  public class Program
    {
      public static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");
            string s = "sfaeratwg ssss!";
            Console.WriteLine(s);
            Console.WriteLine("===========");
           RemoveDuplicates(s);
        }


        public static void RemoveDuplicates(string input)
        {

            List<char> list = new List<char>();
            for(int i=0; i < input.Length; i++)
            {
                if (!list.Contains(input[i]))
                {
                    list.Add(input[i]);
                }
            }

         string res=  String.Join("", list.ToArray());
            Console.WriteLine(res);
        }

    }
}
