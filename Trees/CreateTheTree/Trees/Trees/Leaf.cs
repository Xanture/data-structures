﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class Leaf
    {
        public int Value;
        public Leaf Left;
        public Leaf Right;

        public Leaf(int data)
        {
            Value = data;
            Left = null;
            Right = null;
        }
    }
}