
namespace StackandQuePalindrome
{
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
