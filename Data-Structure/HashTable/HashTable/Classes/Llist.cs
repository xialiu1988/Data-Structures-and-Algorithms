using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
   public class Llist
    {
        public Node root { get; set; }
        public Llist()
        {
            root = new Node();
        }

        /// <summary>
        /// insert a item into the linkedlist
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void add(int key,string val)
        { 
            Node n = new Node(key, val);
            Node curr = root;
            while (curr.Next != null)
            {
                if (curr.Next.Key == key)
                {
                    curr.Next.Value = val;
                    return;
                }
                curr = curr.Next; 
            }
            curr.Next = n;
        }

        /// <summary>
        /// delete an item from llist
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool delete(int key)
        {
            Node curr = root;
            while (curr.Next != null)
            {
                if (curr.Next.Key == key)
                {
                    curr.Next = curr.Next.Next;
                    return true;
                }
               curr = curr.Next; 
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
            Node cur = root;
            while (cur.Next != null)
            {
                if (cur.Next.Key == key)
                {
                    return cur.Next.Value;
                }
               cur = cur.Next;
            }
            return "Not Exsits";
        }

        /// <summary>
        /// traversal llist output all values 
        /// </summary>
        /// <returns></returns>
        public string getlist()
        {
            string str = "";
            Node cur = root.Next;
            while (cur != null)
            {
                str += "(" + cur.Key + "," + cur.Value + "),";
                cur = cur.Next;
            }
            return str;
        }



    }
}
