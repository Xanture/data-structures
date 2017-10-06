using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TreeTransveral
{
    class Tree
    {
        public Node root;

        public Tree(Node data)
        {
            root = data;
        }

        public void PrintTree(Node L, ref string s)
        {
            if (L.Left != null)
            {
                PrintTree(L.Left, ref s);
                s = s + L.Value.ToString().PadLeft(3);
            }
            else
            {
                s = s + L.Value.ToString().PadLeft(3); 
            }
            if (L.Right != null)
            {
                PrintTree(L.Right, ref s);
            }
            Console.WriteLine(s);
        }
    }
}
