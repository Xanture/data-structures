using System;
using System.ComponentModel.Design.Serialization;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            Tree tree = new Tree(root);
            root.Right = new Node(2);
            root.Left = new Node(3);
            root.Right.Right = new Node(4);
            root.Right.Left = new Node(5);
            root.Left.Left = new Node(6);
            root.Left.Right = new Node(7);

            Console.Read();
        }
    }
}
