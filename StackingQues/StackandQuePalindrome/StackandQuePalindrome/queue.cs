using System;
using System.Collections.Generic;
using System.Text;

namespace StackandQuePalindrome
{
    class Queue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public Queue(string data)
        {
            Head = new Node(data);
            Tail = Head;
        }

        public void Enqueue(string data)
        {
            Node buffer = Tail;
            Tail.Next = new Node(data);
            Tail = Tail.Next;
            Tail.Prev = buffer;
        }

        public string IsPalindrome()
        {
            Node start = Head;
            Node end = Tail;

            while (start.Next != null && end.Prev != null)
            {
                if (start.Data.Equals(end.Data))
                {
                    start = start.Next;
                    end = end.Prev;
                }
                else
                {
                    return "Get Rekd (Not an Palindrome)";
                }
            }
            return "You win! (Is an Palindrome)";
        }
    }
}
