using System;

namespace PostPreORDER
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

            string InOrderString = "";
            tree.InOrder(root, ref InOrderString);
            Console.WriteLine("Press AnyKey for PostOrderListz with a Z");
            Console.ReadLine();
            string PostOrderString = "";
            tree.PostOrder(root, ref PostOrderString);

        }
    }
}
