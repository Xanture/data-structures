using System;

namespace Linked_List_Find_Middle
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList(24);
            myList.Add(13);
            myList.Add(15);
            myList.Add(9);
            myList.Add(8);
            myList.PrintMiddle();
            Console.WriteLine(myList.midCount);
        }
    }
}
