using HashTable.Classes;
using System;

namespace HashTable
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            Hash_table ht = new Hash_table(10);
            ht.add(4, "good");
            ht.add(3, "bad");
            ht.add(5, "duplicate");
            ht.add(2, "sky");
            ht.add(11, "team");
            ht.add(7, "seahwak");
            ht.add(1, "wiskey");

         

            Console.WriteLine($"what is value paired with key 3? {ht.get(3)}");
            Console.WriteLine("==========");
            Console.WriteLine($"does the table contains key 2?  {ht.Contains(2)}");
            Console.WriteLine("==========");
            Console.WriteLine($"what is value paired with key 2? {ht.get(2)}");
            Console.WriteLine("==========");
            Console.WriteLine($"what is value paired with key 111? {ht.get(111)}");

        }
    }
}
