using System;
using System.Collections.Generic;
using System.Text;

namespace SortedStack
{
    class Stack
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        //Empty constructor for when I want to make a stack that doesn't start with a value
        public Stack()
        {
            Head = null;
        }

        //Constructor for when I create a stack I want it created with a Node and set that Node to head
        public Stack(int data)
        {
            Head = new Node(data);
            Tail = Head;
        }

        //Push checking for empty Stack then it's setting a new head on top of the stack and creating a reference to the next below
        public void Push(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
                Tail = Head;
            }
            else
            {
                Node temp = Head;
                Head = new Node(data);
                Head.Next = temp;
            }

        }

        //Pop is removing the reference to the top node and returning it
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

        public void SortThisStackMeow(Stack stackData)
        {
            Stack filter = new Stack();
            Stack queue = new Stack();
            bool checker = false;

            do
            {
                Node temp = stackData.Head;
                if (temp.Next == null  || temp.Data <= temp.Next.Data)
                {
                    temp = Head.Next;
                    filter.Push(stackData.Pop());
                }
                else
                {
                    queue.Push(stackData.Pop());
                }
            } while (stackData.Head != null);
            if (queue.Head == null)
            {
                checker = true;
            }
            while (queue.Head != null)
            {
                filter.Push(queue.Pop());
            }
            while (checker == false)
            {
                filter.SortThisStackMeow(filter);
            }


            filter.View();
        }
    }
}
