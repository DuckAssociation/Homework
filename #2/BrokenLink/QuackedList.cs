using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenLink
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }
    }

    // Implement linked list data structure and all missing public members of it
    public class QuackedList
    {
        private Node _head; // -\_(O.o)_/-

        public string Head
        {
            get
            {
                throw new NotImplementedException(); // should return first element of list
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Remove(string item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException(); // should print all members separated by comma (CSV format) - 1,2,3,4
        }

        public string ToStringReverse()
        {
            throw new NotImplementedException(); // should print all members separated by comma in reverse order (figure the best and most performant way) - 4,3,2,1
        }

        public string this[int index] // indexer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
