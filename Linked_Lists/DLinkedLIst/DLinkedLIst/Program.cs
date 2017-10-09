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
        }
    }
}
