﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DLinkedLIst
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node()
        {
            Next = null;
            Prev = null;
        }
        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
