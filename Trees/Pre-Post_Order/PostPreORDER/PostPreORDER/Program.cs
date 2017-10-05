using System;

namespace PostPreORDER
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

            string InOrderString = "";
            tree.InOrder(root, ref InOrderString);
            Console.WriteLine("Press AnyKey for PostOrderListz with a Z");
            Console.ReadLine();
            string PostOrderString = "";
            tree.PostOrder(root, ref PostOrderString);

        }
    }
}
