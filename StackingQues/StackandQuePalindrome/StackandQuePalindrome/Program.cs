using System;

namespace StackandQuePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queueList = new Queue("A");
            queueList.Enqueue("B");
            queueList.Enqueue("C");
            queueList.Enqueue("D");
            
            Console.WriteLine(queueList.IsPalindrome());
        }
    }
}
