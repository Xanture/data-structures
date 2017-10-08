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

            Queue doesitworkmeowquestionmark = new Queue("m");
            doesitworkmeowquestionmark.Enqueue("u");
            doesitworkmeowquestionmark.Enqueue("r");
            doesitworkmeowquestionmark.Enqueue("d");
            doesitworkmeowquestionmark.Enqueue("e");
            doesitworkmeowquestionmark.Enqueue("r");
            doesitworkmeowquestionmark.Enqueue("f");
            doesitworkmeowquestionmark.Enqueue("o");
            doesitworkmeowquestionmark.Enqueue("r");
            doesitworkmeowquestionmark.Enqueue("a");
            doesitworkmeowquestionmark.Enqueue("j");
            doesitworkmeowquestionmark.Enqueue("a");
            doesitworkmeowquestionmark.Enqueue("r");
            doesitworkmeowquestionmark.Enqueue("o");
            doesitworkmeowquestionmark.Enqueue("f");
            doesitworkmeowquestionmark.Enqueue("r");
            doesitworkmeowquestionmark.Enqueue("e");
            doesitworkmeowquestionmark.Enqueue("d");
            doesitworkmeowquestionmark.Enqueue("r");
            doesitworkmeowquestionmark.Enqueue("u");
            doesitworkmeowquestionmark.Enqueue("m");

            Console.WriteLine(doesitworkmeowquestionmark.IsPalindrome());
            Console.Read();
        }
    }
}
