using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST(30);
            bst.Add(20);
            bst.Add(25);
            bst.Add(15);
            bst.Add(45);
            bst.Add(40);
            bst.Add(35);

            bst.Traverse(bst.Root);
            Console.WriteLine();
            bst.TopDown(bst.Root);
            Console.WriteLine();

            Console.Read();
        }
    }
}
