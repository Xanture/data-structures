using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreadthFirst
{
    class Tree
    {
        public Node root;

        public Tree(Node data)
        {
            root = data;
        }

        public void BreadthFirstPrint(Node data)
        {
            Queue<Node> queue = new Queue<Node>(); 
            queue.Enqueue(data);
            while (queue.Count > 0)
            {
                data = queue.Dequeue();
                Console.Write(data.Value);

                if (data.Left != null)
                {
                    queue.Enqueue(data.Left);
                }
                if (data.Right != null)
                {
                    queue.Enqueue(data.Right);
                }
            }
        }

    }
}
