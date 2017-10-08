using System;

namespace Queuefromtwostacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(1);
            queue.stack1.Push(2);
            queue.stack1.Push(3);
            queue.stack1.Push(4);

            queue.Dequeue();

            queue.View();
        }
    }
}
