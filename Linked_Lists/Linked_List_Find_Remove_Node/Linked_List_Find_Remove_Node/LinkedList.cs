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
            Console.Write(curr.Data);
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write("->");
                Console.Write(curr.Data);

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
                Console.Write(curr.Data.ToString());
                Console.Write("->");
                start++;
            }
            Console.Write("<---- This is the Mid");
            Console.WriteLine();
            Console.Read();
        }

        public void Remove(int nodeToRemove)
        {
            Console.Write("Head ->");
            Node curr = head;
            Node curr2 = head;

            do
            {
                if (nodeToRemove.Equals(curr.Data))
                {
                    curr2 = curr;
                    curr2 = null;
                    curr = curr.Next;

                }
                Console.Write(curr.Data);
                curr = curr.Next;
                Console.Write("->");

            }
            while (curr != null) ;
            Console.Write("<----Tail");

        }

    }
}