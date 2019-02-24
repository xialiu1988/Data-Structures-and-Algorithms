using System;
using System.Collections;
using System.Collections.Generic;

namespace MockInterview1_MostCommonWordInaBook
{
   public class Program
    {
      public  static void Main(string[] args)
        {

            // string s1 = "In a galaxy far far away";
            // string s3 = "Taco cat ate a taco";
            //string s2 = "No. Try not. Do or do not. There is no try.";
            string test = "dog dog cat cat";
           string res= MostCommonwordInbook(test);
            Console.WriteLine(test);
            Console.WriteLine("============================");
            Console.WriteLine($"the most common word is {res} .");
        }
        /// <summary>
        /// take in a string 
        /// </summary>
        /// <param name="s"></param>
        /// <returns>a word which is most frequently appear in the string</returns>
        public static string MostCommonwordInbook(string s)
        {
           s= s.Replace('.',' ');
            s = s.ToLower();
            //convert string to an array
            string[] words = s.Split(' ');
            Dictionary<string, List<int>> ht = new Dictionary<string, List<int>>();
            int counter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 0)
                {
                    //if key already in the dictionary, just add counter to the list with the same key
                    if (ht.ContainsKey(words[i]))
                    {
                        counter++;
                        ht[words[i]].Add(counter);
                        counter++;
                    }
                    else
                    {//if it is a new key in the dictionary create a list for it
                        ht.Add(words[i], new List<int> { counter });
                        counter++;
                    }
                }

            } 



            int max = 0;
            string w = "";

            foreach (string key in ht.Keys)
            {//get the Count for every list paired with key, the larger the count is means that key repeated most times
                if (ht[key].Count > max)
                {
                    max =ht[key].Count;
                    w = key;

                }

            }

            return w;

        }
    }
}
