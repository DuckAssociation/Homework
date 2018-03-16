namespace Lecture3.Queue
{
    internal class QueueNode
    {
        public Person Value { get; set; }

        public QueueNode Next { get; set; }

        public QueueNode Previous { get; set; }
    }
}
