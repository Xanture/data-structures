using System;
using System.Collections;
using System.Collections.Generic;

namespace Linked_List_Find_Middle
{
    class LinkedList
    {
        public Node head;
        public Node curr;
        public int count;
        public int midCount;

        public LinkedList(int data)
        {
            head = new Node(data);
            curr = head;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.Data = data;
            curr.Next = newNode;
            curr = newNode;
            count++;
            if (count % 2 == 1)
            {
                midCount++;
            }
        }

        public void PrintAllNodes()
        {
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next !=null)
            {
                curr = curr.Next;
                Console.Write(curr.Data);
                Console.Write("->");
            }
            Console.Write("<----You've steped on my tail");
        }

        public void PrintMiddle()
        {
            int start = 0;
            Console.Write("Head ->");
            Node curr = head;
            while (start < midCount)
            {
                curr = curr.Next;
                Console.Write(curr.Data);
                Console.Write("->");
                start++;
            }
            Console.Write("<---- This is the Mid");
            Console.WriteLine();
            Console.Read();
        }
    }
}
