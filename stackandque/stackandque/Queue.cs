using System;
using System.Runtime.InteropServices;

namespace stackandque
{
    partial class Program
    {
        class Queue<T>
        {
            public Node<T> Head { get; set; }
            public Node<T> Tail { get; set; }

            public Queue(T data)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }

            public void Enqueue(T data)
            {
                Tail.Next = new Node<T>(data);
                Tail = Tail.Next;
            }

            public T Dequeue()
            {
                if (Head == Tail)
                {
                    Tail = null;
                }
                Node<T> temp = Head.Next;
                Head.Next = null;
                T value = Head.Data;
                Head = temp;
                return value;
            }

            public void View()
            {
                Node<T> curr = Head;
                while (curr != null)
                {
                    Console.WriteLine(curr.Data);
                    curr = curr.Next;
                }
            }
        }
    }
}
