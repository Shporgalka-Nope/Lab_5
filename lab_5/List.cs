using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class CList
    {
        private Node[] nodes;
        public Node this[int index]
        {
            get 
            { 
                try
                {
                    if (index > nodes.Length-1 | index < 0) { throw new IndexOutOfRangeException(); }
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.TargetSite);
                    return null;
                }
                return nodes[index]; 
            }
            set { nodes[index] = value; }
        }

        public Node head;
        private int maxCount = 1;
        private int count = 0;

        public CList(int amount)
        {
            maxCount = amount;
            nodes = new Node[maxCount];
        }

        public void Push(int data)
        {
            try
            {
                if (count == maxCount) { throw new ListOverflowException(); }
                if (data < 0 | count > 100) { throw new ListDataOutOfRangeException(); }
            }
            catch(ListOverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception method: " + ex.TargetSite);
                return;
            }
            catch(ListDataOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception method: " + ex.TargetSite);
                return;
            }
            if (head == null) { head = new Node(data); }
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            count++;
        }
        public Node Pop()
        {
            try
            {
                if (count == 0) { throw new ListIsEmpty(); }
            }
            catch(ListIsEmpty ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception method: " + ex.TargetSite);
                return null;
            }
            Node headNode = head;
            head = head.next;
            headNode.next = null;
            count--;
            return headNode;
        }
        public Node Find(int key)
        {
            Node current = head;
            while (current.data != key)
            {
                current = current.next;
            }
            try
            {
                if (current == null) { throw new NoObjectFound(); }
            }
            catch (NoObjectFound ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                return null;
            }
            return current;
        }
        
    }
}
