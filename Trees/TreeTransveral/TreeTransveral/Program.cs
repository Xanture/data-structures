using System;

namespace TreeTransveral
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf root = new Leaf(1);
            Tree tree = new Tree(root);
            root.Right = new Leaf(2);
            root.Left = new Leaf(3);
            root.Right.Right = new Leaf(4);
            root.Right.Left = new Leaf(5);
            root.Left.Left = new Leaf(6);
            root.Left.Right = new Leaf(7);

            string startString = "";
            tree.PrintTree(root, ref startString);
            Console.Read();
        }
    }
}
