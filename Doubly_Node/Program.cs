using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList1 LinkList = new LinkedList1();

            LinkList.AddFirst(new Node(0));
            LinkList.Print();
            LinkList.AddFirst(new Node(1));
            LinkList.Print();
            LinkList.AddFirst(new Node(2));
            LinkList.Print();
            LinkList.AddLast(new Node(3));

            LinkList.Print();

            LinkList.RemoveLast();

            LinkList.Print();
        }

        public class Node
        {
            public Node Next;
            public Node Prev;
            public int Value;

            public Node(int value)
            {
                Value = value;
            }
        }

        public class LinkedList1
        {
            private Node _head;

            public void AddFirst(Node node)
            {
                if (_head == null)
                {
                    _head = node;
                    node.Next = null;
                    node.Prev = node;
                    return;
                }

                node.Next = _head;
                node.Prev = _head.Prev;
                _head.Prev = node;
                _head = node;
            }

            public void AddLast(Node node)
            {
                if (_head == null)
                {
                    _head = node;
                    node.Next = null;
                    node.Prev = node;
                    return;
                }

                node.Next = null;
                node.Prev = _head.Prev;
                _head.Prev.Next = node;
                _head.Prev = node;
            }

            public void RemoveFirst()
            {
                if (_head == null)
                {
                    return;
                }

                if (_head.Next == null)
                {
                    _head = null;
                    return;
                }

                _head.Next.Prev = _head.Prev;
                _head = _head.Next;
            }

            public void RemoveLast()
            {
                if (_head == null)
                {
                    return;
                }

                if (_head.Next == null)
                {
                    _head = null;
                    return;
                }

                _head.Prev.Prev.Next = null;
                _head.Prev = _head.Prev.Prev;
            }

            public void Print()
            {
                Node curent = _head;

                while (curent != null)
                {
                    Console.Write(curent.Value + " ");
                    curent = curent.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
