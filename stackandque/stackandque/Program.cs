using System;

namespace stackandque
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Stack<int> newStack = new Stack<int>(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            newStack.Push(6);
            newStack.Push(7);

            newStack.View();

            newStack.Pop();

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
