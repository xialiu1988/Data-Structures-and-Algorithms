using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace left_join
{
  public  class Program
    {
      public  static void Main(string[] args)
        {
            Hashtable hs1 = new Hashtable();
            hs1.Add("fond", "enamored");
            hs1.Add("wrath", "anger");
            hs1.Add("diligent", "employed");
            hs1.Add("outift", "garb");

            Hashtable hs2 = new Hashtable();
            hs2.Add("fond", "average");
            hs2.Add("wrath", "delight");
            hs2.Add("guide", "follow");

            //printout table one which is left table
            foreach (string key in hs1.Keys)
            {
                 Console.WriteLine(String.Format("{0}: {1}", key, hs1[key]));
            }

            Console.WriteLine("  ");
        //print out the right table
            foreach (string key in hs2.Keys)
            {
                Console.WriteLine(String.Format("{0}: {1}", key, hs2[key]));
            }
            Console.WriteLine("===================");
        //get the list from the method
            List<string> list= Leftjointables(hs1, hs2);
       //print the list out to the console.
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("["+list[i]+ "]");      
            }

        }

        /// <summary>
        /// leftjoin table 
        /// </summary>
        /// <param name="hs1"></param>
        /// <param name="hs2"></param>
        /// <returns></returns>
        public static List<string> Leftjointables(Hashtable hs1,Hashtable hs2)
        {
            List<string> list = new List<string>();
            foreach (string key in hs1.Keys)
            {

                //if both table has the key will add both values to the list
                if (hs2.Contains(key))
                {
                    list.Add(key + ":" + hs1[key] + "," + hs2[key]);
                }

                else
                {//onlu add left table's value to the list
                    list.Add(key + ":" + hs1[key] + "," + "null");
                
                }
            }
               
            return list;

        }
    }
}
