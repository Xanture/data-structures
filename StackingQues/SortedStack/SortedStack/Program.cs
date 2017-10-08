using System;

namespace SortedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(2);
            stack.Push(3);
            stack.Push(5);
            stack.Push(1);
            stack.Push(4);
            stack.Push(6);
            stack.Push(1);

            //stack.View();

            Console.WriteLine();

            stack.SortThisStackMeow(stack);
        }
    }
}
