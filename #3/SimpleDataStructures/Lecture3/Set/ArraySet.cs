namespace Lecture3.Set
{
    public class ArraySet
    {
        private int _count = 0;
        private Person[] _people = new Person[10];

        public void Add(Person person)
        {
            if (!Contains(person))
            {
                // Find empty spot
                int emptySpot = -1;
                for (int i = 0; i < _people.Length; i++)
                {
                    if (emptySpot == -1 && _people[i] == null)
                    {
                        emptySpot = i;
                    }
                }
                
                if(emptySpot == -1)
                {
                    // No empty spot is available, grow the array.
                    int oldSize = _people.Length;
                    int newSize = oldSize * 2;
                    Person[] newArray = new Person[newSize];
                    for(int i = 0; i < oldSize; i++)
                    {
                        newArray[i] = _people[i];
                    }
                    _people = newArray;
                    // If old awway had lenght of 10 then last index would be 9 (becuase we count from 0).
                    // Our new array is of length 10 * 2. Next empty spot would be at index 10 (11th element). 
                    emptySpot = oldSize;
                }

                // Add person to list
                _people[emptySpot] = person;

                // Increment counter
                _count++;
            }
        }

        public bool Contains(Person person)
        {
            bool personIsInArray = false;
            for (int i = 0; i < _people.Length; i++)
            {
                if (_people[i] == person)
                {
                    personIsInArray = true;
                }
            }

            return personIsInArray;
        }

        public void Remove(Person person)
        {
            if (Contains(person))
            {
                for (int i = 0; i < _people.Length; i++)
                {
                    if (_people[i] == person)
                    {
                        _people[i] = null;
                    }
                }

                _count--;
            }
        }

        public int Count()
        {
            return _count;
        }

        public Person[] GetAllPeople()
        {
            Person[] result = new Person[Count()];
            int currentPosition = 0;
            for (int i = 0; i < _people.Length; i++)
            {
                if (_people[i] != null)
                {
                    result[currentPosition] = _people[i];
                    currentPosition = currentPosition + 1;
                }
            }
            return result;
        }
    }
}
