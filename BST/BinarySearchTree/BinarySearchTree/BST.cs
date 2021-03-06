﻿using System;
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

        public Node FindMin(Node currRoot)
        {
            while (currRoot.Left != null)
            {
                currRoot = currRoot.Left;
            }
            return currRoot;
        }

        public Node FindMax(Node currRoot)
        {
            while (currRoot.Right != null)
            {
                currRoot = currRoot.Right;
            }
            Console.WriteLine(currRoot.Data);
            return currRoot;
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

        public void TopDown(Node currRoot)
        {
            if (currRoot != null)
            {
                Console.Write($"<-{currRoot.Data}->");
                TopDown(currRoot.Left);
                TopDown(currRoot.Right);
            }
        }
    }
}
