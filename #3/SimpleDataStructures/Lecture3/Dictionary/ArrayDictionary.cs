namespace Lecture3.Dictionary
{
    public class ArrayDictionary
    {
        private int _count = 0;
        private KeyValuePair[] _pairs = new KeyValuePair[10];

        public void Add(string key, Person person)
        {
            if (!ContainsKey(key))
            {
                // New pair that we will insert into dictionary
                KeyValuePair newPair = new KeyValuePair
                {
                    Key = key,
                    Value = person
                };

                // find empty spot
                int emptySpot = -1;
                for (int i = 0; i < _pairs.Length; i++)
                {
                    if (_pairs[i] == null)
                    {
                        emptySpot = i;
                    }
                }

                //TODO: Grow if needed

                // insert into empty spot
                _pairs[emptySpot] = newPair;

                _count++;
            }
        }

        public Person GetByKey(string key)
        {
            if (ContainsKey(key))
            {
                KeyValuePair resultPair = null;
                for (int i = 0; i < _pairs.Length; i++)
                {
                    // Short-circuiting used here to check for null before accessing pair.Key reference.
                    if (_pairs[i] != null && _pairs[i].Key == key)
                    {
                        resultPair = _pairs[i];
                    }
                }
                return resultPair.Value;
            }
            else
            {
                return null;
            }
        }

        public void RemoveByKey(string key)
        {
            if (ContainsKey(key))
            {
                for (int i = 0; i < _pairs.Length; i++)
                {
                    // Short-circuiting used here to check for null before accessing pair.Key reference.
                    if (_pairs[i] != null && _pairs[i].Key == key)
                    {
                        // And now set pair to null, this "removes" the pair.
                        _pairs[i] = null;
                    }
                }

                _count--;
            }
        }

        // This method can be made to run faster. How?
        public bool ContainsKey(string key)
        {
            bool contains = false;
            for (int i = 0; i < _pairs.Length; i++)
            {
                KeyValuePair pair = _pairs[i];
                // Short-circuiting used here to check for null before accessing pair.Key reference.
                if (pair != null && pair.Key == key)
                {
                    contains = true;
                }
            }
            return contains;
        }

        public int Count()
        {
            return _count;
        }
    }
}
