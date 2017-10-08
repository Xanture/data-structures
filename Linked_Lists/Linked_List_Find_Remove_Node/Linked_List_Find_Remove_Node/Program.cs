using System;
using Microsoft.Win32.SafeHandles;

namespace Linked_List_Find_Remove_Node
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList linked = new LinkedList(1);
            linked.Add(2);
            linked.Add(3);
            linked.Add(4);
            linked.Add(5);
            linked.Add(6);
            linked.Add(7);

            linked.Remove(6);
        }
    }
}
