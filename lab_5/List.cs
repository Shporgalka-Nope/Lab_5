using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class CList<T> where T : IComparable
    {
        private Node<T>[] nodes;
        public Node<T> this[int index]
        {
            get { return nodes[index]; }
            set { nodes[index] = value; }
        }

        public Node<T> head;
        private int maxCount = 1;
        private int count = 0;

        public CList(int amount)
        {
            maxCount = amount;
            nodes = new Node<T>[maxCount];
        }

        public void Push(T data)
        {
            if (head == null) { head = new Node<T>(data); }
            Node<T> newNode = new Node<T>(data);
            newNode.next = head;
            head = newNode;
            count++;
        }
        public Node<T> Pop()
        {
            Node<T> headNode = head;
            head = head.next;
            headNode.next = null;
            count--;
            return headNode;
        }
        public void Check()
        {
            Node<T> current = head;
            do
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            while (current != null);
        }



        //public Node<T> Find(T key)
        //{
        //    Node<T> current = head;
        //    while (current.data == key)
        //    {
        //        current = current.next;
        //    }
        //    return current;
        //}
    }
}
