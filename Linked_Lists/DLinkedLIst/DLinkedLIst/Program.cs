using System;

namespace DLinkedLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(2);
            Node node2 = new Node(3);
            Node node3 = new Node(6);
            Node node4 = new Node(7);

            DLinkedList dLinked = new DLinkedList();
            dLinked.AddLast(node1);
            dLinked.AddLast(node2);
            dLinked.AddLast(node3);
            dLinked.AddLast(node4);

            Console.WriteLine("Base List:");
            dLinked.View();
            Console.WriteLine("\n");

            Console.WriteLine("AddFirst: 1 Before 2");
            dLinked.AddFirst(new Node(1));
            dLinked.View();
            Console.WriteLine("\n");

            Console.WriteLine("AddAfter: Target Node 3, adding 4 after");
            dLinked.AddAfter(node2, 4);
            dLinked.View();
            Console.WriteLine("\n");

            Console.WriteLine("AddBefore: Target Node 6 adding 5 before");
            dLinked.AddBefore(node3, 5);
            dLinked.View();
            Console.WriteLine("\n");

            Console.WriteLine("Delete: Target Node 7 for MAXIMUM DELETION");
            dLinked.Delete(7);
            dLinked.View();
            Console.WriteLine("\n\n Thanks for grading!");

            Console.Read();
        }
    }
}
