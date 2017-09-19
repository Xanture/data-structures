using System;
using System.Threading;

namespace Linked_List
{
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
            current = newNode;
            count++;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Data = data};
            newNode.Next = head.Next;
            head.Next = newNode;
            count++;
        }

        public void PrintAllNodes()
        {
            Console.Write("The Head: ");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Data);
                Console.Write("->");
            }
            Console.Write("You've step'd on my tail");
        }
    }
}