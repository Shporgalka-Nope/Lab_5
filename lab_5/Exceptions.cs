using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    //Head Class
    internal class ListExceptions : ApplicationException
    {
        public ListExceptions(string message) : base(message) { }
    }

    //List out of range classes
    internal class ListIsOutOfRangeException : ListExceptions 
    {
        public ListIsOutOfRangeException(string message) : base(message) {}
    }
    internal class ListIndexOutOfRangeException : ListIsOutOfRangeException
    {
        public ListIndexOutOfRangeException() : base("Given index is out of list range") {}
    }
    internal class ListDataOutOfRangeException : ListIsOutOfRangeException
    {
        public ListDataOutOfRangeException() : base("Given data is out of range") {}
    }

    //List objects exceptions
    internal class ListObjectExceptions : ListExceptions
    {
        public ListObjectExceptions(string message) : base(message) { }
    }
    internal class ListIsEmpty : ListObjectExceptions
    {
        public ListIsEmpty() : base("Current list is empty") {}
    }
    internal class NoObjectFound : ListObjectExceptions
    {
        public NoObjectFound() : base("Given object data does not exist in given list") {}
    }

    //List volume exceptions
    internal class ListVoumeExceptions : ListExceptions
    {
        public ListVoumeExceptions(string message) : base(message) {}
    }
    internal class ListOverflowException : ListVoumeExceptions
    {
        public ListOverflowException() : base("Given object is overflowing the list") {}
    }
    internal class ListUnderflowException : ListVoumeExceptions
    {
        public ListUnderflowException() : base("Given object is underflowing the list") {}
    }
}
