using System;

namespace DLinkedLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            DLinkedList dLinked = new DLinkedList();
            dLinked.AddLast(node1);
            dLinked.AddLast(node2);
            dLinked.AddLast(node3);
            dLinked.AddLast(node4);

            Console.WriteLine("Base List:");
            dLinked.View();
            Console.WriteLine("\n");

            Console.WriteLine("AddFirst: 2 Before 1");
            dLinked.AddFirst(new Node(2));
            dLinked.View();
            Console.WriteLine("\n");

            Console.WriteLine("AddAfter: Target Node 3, adding 7 after");
            dLinked.AddAfter(node3, 7);
            dLinked.View();
            Console.WriteLine("\n");

            Console.WriteLine("AddBefore: Target Node 4 adding 8 after");
            dLinked.AddAfter(node4, 8);

            Console.Read();
        }
    }
}
