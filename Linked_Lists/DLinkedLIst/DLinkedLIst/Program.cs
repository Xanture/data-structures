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

            dLinked.AddFirst(new Node(2));

            dLinked.AddAfter(node3, 7);

            dLinked.View();

            Console.Read();
        }
    }
}
