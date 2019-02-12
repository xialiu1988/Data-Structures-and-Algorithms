using System;
using System.Collections.Generic;

namespace charactersinastringareunique
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            string s = "unnnn";
            bool boo = CheckaUniqueChars(s);
            Console.WriteLine($"is the string has unique characters? {boo}");
        }


        public static bool CheckaUniqueChars(string s)
        {//assume empty string doesn't have any chars should return false
            if (s.Length == 0 || s == null)
            {
                return false;
            }

            List<char> list = new List<char>();

            char[] arr = s.ToCharArray();


            for (int i = 0; i < arr.Length; i++)
            {
                if (list.Contains(arr[i])) return false;
                else { list.Add(arr[i]); }
            }

            return true;
        }
    }
}
