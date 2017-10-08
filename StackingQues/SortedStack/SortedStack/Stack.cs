using System;
using System.Collections.Generic;
using System.Text;

namespace SortedStack
{
    class Stack
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        //Constructor for when I create a stack I want it created with a Node and set that Node to head
        public Stack(int data)
        {
            Head = new Node(data);
            Tail = Head;
        }

        //Push is setting a new head on top of the stack and creating a reference to the next below
        public void Push(int data)
        {
            Node temp = Head;
            Head = new Node(data);
            Head.Next = temp;
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
    }
}
