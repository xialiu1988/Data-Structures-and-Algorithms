using System;
using System.Collections;
using System.Collections.Generic;

namespace RepeatedWord
{
    public class Program
    {
      public  static void Main(string[] args)
        {
           string str = " It of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string str2 = "It was a queer, sultry summer the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            string str3 = "Once upon a time, there was a brave princess who...";
            string s = RepeatedWord(str3);
            Console.WriteLine($"the repeated word is: {s}");
        }

        public static string RepeatedWord(string str)
        {

           str=str.Replace(',', ' ');
            str = str.Replace('.', ' ');
            string[] arr = str.Split(' ');

            //initialize a hashset to store unique word
            HashSet<string> hs = new HashSet<string>();

            for(int i = 0; i < str.Length; i++)
            {
                arr[i]= arr[i].ToLower();
                if (!hs.Add(arr[i]))
                {  //find the one already exsits in hashset return that word 
                    return arr[i];
                }

            }

            return "No repeated word in this string";
        }
    }
}
