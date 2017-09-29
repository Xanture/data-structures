using System;

namespace Queuefromtwostacks
{
    class Stack
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public Stack()
        {
            Tail = Head;
        }

        public Stack(int data)
        {
            Head = new Node (data);
            Tail = Head;
        }

        public void Push(int data)
        {
            Node temp = Head;
            Head = new Node(data);
            Head.Next = temp;
        }

        public int Pop()
        {
            if (Head == Tail)
            {
                Tail = null;
            }
            Node temp = Head.Next;
            Head.Next = null;
            int value = Head.Data;
            Head = temp;
            return value;
        }

        public void View()
        {
            Node curr = Head;
            while (curr != null)
            {
                Console.WriteLine(curr.Data);
                curr = curr.Next;
            }
        }

    }
}
