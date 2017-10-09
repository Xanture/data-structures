using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public DLinkedList(int Data)
        {
            Head = new Node(Data);
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
    }
}
