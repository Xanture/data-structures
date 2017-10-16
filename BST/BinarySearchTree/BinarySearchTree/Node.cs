using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node : BST
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
