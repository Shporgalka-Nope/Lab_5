using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab_5
{
    internal class CList<T> : IEnumerable where T : IComparable
    {
        private Node<T>[] nodes;
        public Node<T> this[int index]
        {
            get 
            { 
                return nodes[index]; 
            }
            set 
            {
                Node<T> node = head;
                if (index == 0)
                {
                    head = value;
                    return;
                }
                for(int i = 0; i < index-1; i++)
                {
                    node = node.next;
                }
                node.next = value;
            }
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
            Node<T> current = head;
            if (head == null) 
            { 
                head = new Node<T>(data);
                nodes[count] = head;
                count++;
                return;
            }
            Node<T> newNode = new Node<T>(data);
            while(current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
            nodes[count] = newNode;
            count++;
        }
        public Node<T> Pop()
        {
            Node<T> toReturn;
            if (head.next == null)
            {
                toReturn = head;
                head = null;
                count = 0;
                nodes[count] = null;
                return toReturn;
            }
            Node<T> headNode = head;
            while(headNode.next.next != null)
            {
                headNode = headNode.next;
            }
            toReturn = headNode.next;
            headNode.next = null;
            count--;
            nodes[count] = null;
            return toReturn;
        }
        public void Check()
        {
            if (head == null) { return; }
            Node<T> current = head;
            do
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            while (current != null);
        }
        public Node<T> Find(T key)
        {
            Node<T> current = head;
            while (current != null && current.data.CompareTo(key) != 0)
            {
                current = current.next;
            }
            return current;
        }

        public IEnumerator GetEnumerator()
        {
            return new ListEnum(nodes);
        }

        private class ListEnum : IEnumerator
        {
            private Node<T>[] collection;

            private int position = -1;
            
            public ListEnum(Node<T>[] nodes)
            {
                collection = nodes;
            }

            public bool MoveNext()
            {
                position++;
                return (position < collection.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            public object Current => collection[position];
        }
    }
}
