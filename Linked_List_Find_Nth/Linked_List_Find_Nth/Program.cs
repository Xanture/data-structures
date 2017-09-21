using System;


namespace Linked_List_Find_Nth
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            linkedList.NthFromEnd(3);
        }
    }
}
