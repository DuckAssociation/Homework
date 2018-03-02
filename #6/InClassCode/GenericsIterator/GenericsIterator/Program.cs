using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            var store = new Store<Book>();
            var book = new Book();
            store.Add(book);
            store.Add(book);
            store.Add(book);
            store.Add(book);
            foreach (var item in store)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    public class Store<TInventoryItem> : IEnumerable<TInventoryItem>
    {
        private List<TInventoryItem> _inventor = new List<TInventoryItem>();
        public void Add(TInventoryItem item)
        {
            System.Console.WriteLine(item);
            _inventor.Add(item);
        }

        public IEnumerator<TInventoryItem> GetEnumerator()
        {
            return new Enumerator(_inventor);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(_inventor);
        }

        public class Enumerator : IEnumerator<TInventoryItem>
        {
            TInventoryItem _current;
            int _index = 0;
            List<TInventoryItem> _target;

            public Enumerator(List<TInventoryItem> target)
            {
                _target = target;
            }

            public TInventoryItem Current => _current;

            object IEnumerator.Current => _current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (_target.Count <= _index) return false;

                _current = _target[_index];
                _index++;
                return true;
            }

            public void Reset()
            {
                _index = -1;
                _current = default(TInventoryItem);
            }
        }
    }

    internal class IceCream
    {
    }

    internal class Book
    {
    }
}



