using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace stackandque
{
    partial class Program
    {
        class Stack<T> : List<T>
        {
            public Node<T> Head { get; set; }
            public Node<T> Tail { get; set; }

            public Stack(T data)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }

            public void Push(T data)
            {
                Node<T> temp = Head;
                Head = new Node<T>(data);
                Head.Next = temp;
            }

            public T Pop()
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
