using System;

namespace stackandque
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Stack<int> newStack = new Stack<int>(2);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(3);
            newStack.Push(12);
            newStack.Push(7);
            newStack.Push(14);

            newStack.View();


            Console.WriteLine();
            newStack.View();

            Console.WriteLine();

            Queue<int> newQueue = new Queue<int>(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);
            newQueue.Enqueue(4);
            newQueue.Enqueue(5);
            newQueue.Enqueue(6);
            newQueue.Enqueue(7);

            newQueue.View();

            newQueue.Dequeue();

            Console.WriteLine();
            newQueue.View();
        }
    }
}
