using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirst
{
    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Value = data;
            Left = null;
            Right = null;
        }

    }
}
