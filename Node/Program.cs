using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList1 LinkList = new LinkedList1();

            LinkList.AddFirst(new Node(0));
            LinkList.AddFirst(new Node(1));
            LinkList.AddFirst(new Node(2));

            LinkList.Print();

            LinkList.RemoveBy(2);

            LinkList.Print();
        }
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

        public void AddFirst(Node node)
        {
            node.Next = _head;
            _head = node;
        }

        public void AddLast(Node node)
        {
            if (_head == null)
            {
                _head = node;
                return;
            }

            Node curent = _head;

            while (curent.Next != null)
            {
                curent = curent.Next;
            }

            curent.Next = node;
        }

        public void RemoveFirst(Node node)
        {
            if (_head == null)
            {
                return;
            }

            _head = _head.Next;
        }

        public void RemoveLast(Node node)
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

                while (curent.Next != null)
                {
                    curent = curent.Next;
                }

                curent.Next = null;
            }
        }

        public void RemoveBy(int value)
        {
            if (_head == null)
            {
                return;
            }

            Node curent= _head;
            Node node2 = null;

            if (curent.Value == value)
            {
                _head = curent.Next;
                return;
            }

            while ((curent.Next != null) && (curent.Value != value))
            {
                node2 = curent;
                curent = curent.Next;
            }

            if (curent.Value != value)
            {
                return;
            }

            node2.Next = curent.Next;
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

