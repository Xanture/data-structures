using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkList = new LinkedList();

            linkList.AddAtLast(12);
            linkList.AddAtLast(13);
            linkList.PrintAllNodes();
        }
    }
}
