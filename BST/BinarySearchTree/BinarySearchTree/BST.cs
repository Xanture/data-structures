using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace BinarySearchTree
{
    class BST
    {
        public Node Root;
        public Node curr;

        public BST(int data)
        {
            Node newNode = new Node(data);
            Root = newNode;
        }

        public void Add(int data)
        {
            curr = Root;
            Node newNode = new Node(data);
            while (true)
            {
                Node ParentNode = curr;
                if (data < curr.Data)
                {
                    curr = curr.Left;
                    if (curr == null)
                    {
                        ParentNode.Left = newNode;
                        break;
                    }
                }
                else
                {
                    curr = curr.Right;
                    if (curr == null)
                    {
                        ParentNode.Right = newNode;
                        break;
                    }
                }
            }
        }

        public void Traverse(Node currRoot)
        {
            if (currRoot != null)
            {
                Traverse(currRoot.Left);
                Console.Write($"<-{currRoot.Data}->");
                Traverse(currRoot.Right);
            }
        }
    }
}
