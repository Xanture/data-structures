using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PostPreORDER
{
    class Tree
    {
        public Leaf root;

        public Tree(Leaf data)
        {
            root = data;
        }

        public void InOrder(Leaf L, ref string s)
        {
            if (L.Left != null)
            {
                InOrder(L.Left, ref s);
                s = s + L.Value.ToString().PadLeft(3);
            }
            else
            {
                s = s + L.Value.ToString().PadLeft(3);
            }
            if (L.Right != null)
            {
                InOrder(L.Right, ref s);
            }
            Console.WriteLine(s);
        }
        public void PostOrder(Leaf L, ref string s)
        {
            if (L.Left != null)
            {
                PostOrder(L.Left, ref s);
                if (L.Right != null)
                {
                    PostOrder(L.Right, ref s);
                }
                s = s + L.Value.ToString().PadLeft(3);

            }
            else
            {
                s = s + L.Value.ToString().PadLeft(3);
            }

            Console.WriteLine(s);
        }

    }
}
