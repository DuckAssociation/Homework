namespace Lecture3.Queue
{
    public class LinkedQueue
    {
        private QueueNode _head;
        private QueueNode _tail;
        private int _count = 0;

        public void Enqueue(Person person)
        {
            _count = _count + 1;

            QueueNode oldHead = _head;
            QueueNode newHead = new QueueNode
            {
                Value = person
            };

            _head = newHead;
            _head.Previous = oldHead;

            if (oldHead == null)
            {
                // Empty queue.
                _tail = _head;
            }
            else
            {
                oldHead.Next = newHead;
            }
        }

        public Person Dequeue()
        {
            _count = _count - 1;

            QueueNode newTail = _tail.Next;
            QueueNode oldTail = _tail;

            _tail = newTail;

            if (_head == oldTail)
            {
                // If there is only 1 element in queue.
                _head = null;
            }

            return oldTail.Value;
        }

        public int Count()
        {
            return _count;
        }
    }
}
