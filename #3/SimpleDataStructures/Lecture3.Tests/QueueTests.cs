using Lecture3.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture3.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void CountIsCorrent_0()
        {
            LinkedQueue queue = new LinkedQueue();

            Assert.AreEqual(0, queue.Count());
        }

        [TestMethod]
        public void CountIsCorrent_1()
        {
            LinkedQueue queue = new LinkedQueue();

            queue.Enqueue(new Person { Name = "Alice" });

            Assert.AreEqual(1, queue.Count());
        }

        [TestMethod]
        public void CountIsCorrent_5()
        {
            LinkedQueue queue = new LinkedQueue();

            queue.Enqueue(new Person { Name = "Alice" });
            queue.Enqueue(new Person { Name = "Bob" });
            queue.Enqueue(new Person { Name = "Charlie" });
            queue.Enqueue(new Person { Name = "Dolan" });
            queue.Enqueue(new Person { Name = "Gooby" });

            Assert.AreEqual(5, queue.Count());
        }

        [TestMethod]
        public void CountIsCorrent_10K()
        {
            LinkedQueue queue = new LinkedQueue();

            for (int i = 0; i < 10000; i++)
            {
                queue.Enqueue(new Person { Name = $"Alice_{i}" });
            }

            Assert.AreEqual(10000, queue.Count());
        }

        [TestMethod]
        public void EnqueueAndDequeueReturnsSamePersonReference()
        {
            LinkedQueue queue = new LinkedQueue();
            Person alice = new Person { Name = "Alice" };

            queue.Enqueue(alice);
            Person personFromQueue = queue.Dequeue();

            Assert.AreSame(alice, personFromQueue);
        }


        [TestMethod]
        public void EnqueueAndDequeueMultipleTimesReturnsCorrectPersonReferences()
        {
            LinkedQueue queue = new LinkedQueue();
            Person alice = new Person { Name = "Alice" };
            Person bob = new Person { Name = "Bob" };
            Person charlie = new Person { Name = "Charlie" };

            // Alice
            queue.Enqueue(alice);
            Person personFromQueue1 = queue.Dequeue();
            Assert.AreSame(alice, personFromQueue1);

            // Bob
            queue.Enqueue(bob);
            Person personFromQueue2 = queue.Dequeue();
            Assert.AreSame(bob, personFromQueue2);

            // Charlie
            queue.Enqueue(charlie);
            Person personFromQueue3 = queue.Dequeue();
            Assert.AreSame(charlie, personFromQueue3);
        }

        [TestMethod]
        public void EnqueueAndDequeueReturnsCorrectOrderOfPersonReferences()
        {
            LinkedQueue queue = new LinkedQueue();
            Person alice = new Person { Name = "Alice" };
            Person bob = new Person { Name = "Bob" };
            Person charlie = new Person { Name = "Charlie" };

            // Enqueue all
            queue.Enqueue(alice);
            queue.Enqueue(bob);
            queue.Enqueue(charlie);

            // Dequeue all
            Person personFromQueue1 = queue.Dequeue();
            Person personFromQueue2 = queue.Dequeue();
            Person personFromQueue3 = queue.Dequeue();

            // Assert that order is the same
            Assert.AreSame(alice, personFromQueue1);
            Assert.AreSame(bob, personFromQueue2);
            Assert.AreSame(charlie, personFromQueue3);
        }

        [TestMethod]
        public void CountIsMaintainedWhenPersonIsEnqueuedAndDequeued()
        {
            LinkedQueue queue = new LinkedQueue();
            Person alice = new Person { Name = "Alice" };
            Person bob = new Person { Name = "Bob" };
            Person charlie = new Person { Name = "Charlie" };

            // Enqueue all and assert Count
            queue.Enqueue(alice);
            Assert.AreEqual(1, queue.Count());
            queue.Enqueue(bob);
            Assert.AreEqual(2, queue.Count());
            queue.Enqueue(charlie);
            Assert.AreEqual(3, queue.Count());

            // Dequeue all and assert Count
            Person personFromQueue1 = queue.Dequeue();
            Assert.AreEqual(2, queue.Count());
            Person personFromQueue2 = queue.Dequeue();
            Assert.AreEqual(1, queue.Count());
            Person personFromQueue3 = queue.Dequeue();
            Assert.AreEqual(0, queue.Count());

        }
    }
}
