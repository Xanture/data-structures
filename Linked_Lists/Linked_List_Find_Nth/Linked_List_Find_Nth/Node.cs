using System;


namespace Linked_List_Find_Nth
{
    class Node
    {
        public Node Next { get; set; }
        public Object Data { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

    }
}
