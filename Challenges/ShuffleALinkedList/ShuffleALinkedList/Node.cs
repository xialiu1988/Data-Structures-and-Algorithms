﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShuffleALinkedList
{
   public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
        }
    }
}
