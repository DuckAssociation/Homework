using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIterator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Factory<T> : IEnumerable<T>
    {
        public void EmployWorker(T employee)
        {
            // TODO: Add an employee in collection of your choise.
        }

        public IEnumerator<T> GetEnumerator()
        {
            // TODO: Create enumerable specific for Factory. Hint both methods should 
            // return same enumerable. New class (Enumerable) should be located inside Factory class.
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // TODO: Create enumerable specific for Factory. Hint both methods should 
            // return same enumerable. New class (Enumerable) should be located inside Factory class.
            throw new NotImplementedException();
        }

        // TODO: Implement missing parts of Enumerator class.
        private class Enumerator : IEnumerator<T>
        {
            // TODO: return Current item in IEnumerable;
            public T Current => throw new NotImplementedException();

            // TODO: return Current item in IEnumerable;
            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                // TODO: Clear all resources. If nothing to clear - ignore.
            }

            public bool MoveNext()
            {
                // TODO: Assign Current a next value and return true or false depending if next value exists.
                throw new NotImplementedException();
            }

            public void Reset()
            {
                // TODO: Reset all state.
                throw new NotImplementedException();
            }
        }
    }


    // TODO: override ToString method in both classes to return class name as a string.
    // So ToString() method would return class name as a string.
    public class Elf { }
    public class Smurf { }
}
