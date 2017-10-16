using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BinarySearchTree
{
    class BST
    {
        public Node Root;
        protected BST()
        {
        }

        public BST(int data)
        {
            Node Root = new Node(data);
        }

        public void Add(int data)
        {
            Node curr = Root;
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

//        public void Traverse()
//        {
//            Node curr = Root;
//            if (curr.Left != null)
//            {
//                
//            }
//            Console.Write(curr.Data);
//            if (curr.Right != null)
//            {
//                
//            }
//        }
    }
}
