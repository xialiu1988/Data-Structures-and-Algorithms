using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
   public class Hash_table
    {
        public Llist[] arr { get; set; }
        public int Size { get; set; }


        /// <summary>
        /// no input ,initialize a hash table--defalut if no input size 
        /// </summary>
        public Hash_table()
        {
            Size = 50;
            arr = new Llist[50];
        }


        /// <summary>
        /// initialize a hash table with a size as input
        /// </summary>
        /// <param name="size"></param>
        public Hash_table(int size)
        {
            Size = size;
            arr = new Llist[size];
        }


        
     /// <summary>
     /// intert value to hash_table
     /// </summary>
     /// <param name="key"></param>
     /// <param name="value"></param>
        public void add(int key,string value)
        {
            int index = Hash(key);
            if (arr[index] == null)
            {
                arr[index] = new Llist();
            }
            arr[index].add(key, value);
        }

        /// <summary>
        /// get hashindex for the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
       public int Hash(int key)
        {
            return key.GetHashCode() % Size;
        }

        /// <summary>
        /// delete an item from hashtable by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool delete(int key)
        {
            int index = Hash(key);
            if (arr[index] != null)
            {
                return arr[index].delete(key);
            }
          return false;
        }

        /// <summary>
        /// get value by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string get(int key)
        {
            int index = Hash(key);
            if (arr[index] != null)
            {
                return arr[index].get(key);
            }

          return "Not available";
        }



        public bool Contains(int key)
        {
            int index = Hash(key);
            if (arr[index] != null)
            {
                return true;
            }
            else return false;

        }

      

    }
}
