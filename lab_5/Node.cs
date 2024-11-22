using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Node<T> where T : IComparable
    {
        public T data;
        public Node<T>? next;

        public Node(T d)
        {
            data = d;
        }
    }
}
