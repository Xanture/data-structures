using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using System.Text;

namespace Trees
{
    class Tree
    {
        public Leaf root;

        public Tree(Leaf data)
        {
            root = data;
        }

    }
}
