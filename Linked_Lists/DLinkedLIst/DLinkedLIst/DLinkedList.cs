using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;

namespace DLinkedLIst
{
    class DLinkedList
    {
        public Node Head;

        public DLinkedList()
        {
           Head = null;
        }

        public DLinkedList(int data)
        {
            Head = new Node(data);
        }

        public DLinkedList(Node data)
        {
            Head = data;
        }

        public void AddLast(Node data)
        {
            if (Head == null)
            {
                Head = new Node(data.Data);
            }
            else
            {
                Node curr = Head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = data;
                data.Prev = curr;
                curr.Next.Prev = curr;
            }
        }

        public void AddFirst(Node data)
        {
            if (Head == null)
            {
                Head = new Node(data.Data);
            }
            data.Next = Head;
            Head.Next.Prev = data;
            Head = data;
            Head.Next.Prev = Head;
        }

        public void AddAfter(Node target, int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            Node newNode = new Node(data);
            Node curr = Head;
            while (curr != target)
            {
                curr = curr.Next;
            }
            newNode.Next = curr.Next;
            newNode.Prev = curr;
            curr.Next.Prev = newNode;
            curr.Next = newNode;
        }



        public void View()
        {
            Console.Write("Head«-»");
            Node curr = Head;
            while (curr.Next != null)
            {
                Console.Write(curr.Data);
                curr = curr.Next;
                Console.Write("«-»");
            }
            Console.Write(curr.Data);
        }
    }
}
