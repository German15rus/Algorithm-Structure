using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_tail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList1 LinkList = new LinkedList1();

            LinkList.AddFirst(new Node(0));
            LinkList.AddFirst(new Node(1));
            LinkList.AddFirst(new Node(2));

            LinkList.AddLast(new Node(3));

            LinkList.Print();
        }
        public class Node
        {
            public Node Next;
            public int Value;

            public Node(int value)
            {
                Value = value;
            }
        }

        public class LinkedList1
        {
            private Node _head;
            private Node _tail;

            public void AddFirst(Node node)
            {
                node.Next = _head;
                _head = node;

                if (_tail == null)
                {
                    _tail = node;
                }
            }

            public void AddLast(Node node)
            {
                if (_head == null)
                {
                    _head = node;
                    return;
                }

                _tail.Next = node;
                node = _tail;
            }

            public void RemoveFirst()
            {
                if (_head == null)
                {
                    return;
                }

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

                else
                {
                    Node curent = _head;

                    while (curent.Next != _tail)
                    {
                        curent = curent.Next;
                    }

                    curent.Next = null;
                }
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
