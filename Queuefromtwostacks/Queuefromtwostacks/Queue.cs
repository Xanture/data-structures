using System;
using System.Collections.Generic;
using System.Text;

namespace Queuefromtwostacks
{
    class Queue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Stack stack1 = new Stack();
        public Stack stack2 = new Stack();

        public Queue(int data)
        {
            stack1 = new Stack(data);
        }

        public void Enqueue(int data)
        {
            Tail.Next = new Node(data);
            Tail = Tail.Next;
        }

        public int Dequeue()
        {
            while (stack1.Head != null)
            {
                stack2.Push(stack1.Pop());
            }
            int temp = stack2.Pop();
            while (stack2.Head != null)
            {
                stack1.Push(stack2.Pop());
            }
            return temp;
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
