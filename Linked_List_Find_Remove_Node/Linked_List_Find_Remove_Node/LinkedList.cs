using System;

namespace Linked_List_Find_Remove_Node
{
    public class LinkedList
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
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Data);
                Console.Write("->");
            }
            Console.Write("<----You've steped on my tail");
        }
        public void NthFromEnd(int Nth)
        {
            int counts = 1;
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                counts++;
            }
            Node curr2 = head;
            for (int i = 0; i < counts - Nth; i++)
            {
                curr2 = curr2.Next;
            }
            Console.WriteLine(curr2.Data);
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

        public void Remove(int nodeToRemove)
        {
            int index = nodeToRemove - 1;
            Console.Write("Head ->");
            Node curr = head;
            Node curr2 = head;
            int innerCount = 0;

            while (curr.Next != null)
            {
                curr = curr.Next;
                innerCount++;
            }
            for (int i = 0; i < count - nodeToRemove; i++)
            {
                curr2 = curr2.Next;
                Console.Write(curr2.Data);
                Console.Write("->");
            }
            curr2 = curr2.Next;
            for (int i = 0; i < index - 1; i++)
            {
                curr2 = curr2.Next;
                Console.Write(curr2.Data);
                Console.Write("->");
            }
            Console.Write("Tail!");
        }

    }
}