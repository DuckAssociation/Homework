using Lecture3.Set;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Lecture3.Tests
{
    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void CountIsCorrect_0()
        {
            ArraySet set = new ArraySet();

            Assert.AreEqual(0, set.Count());
        }

        [TestMethod]
        public void CountIsCorrect_1()
        {
            ArraySet set = new ArraySet();

            set.Add(new Person { Name = "Alice" });

            Assert.AreEqual(1, set.Count());
        }

        [TestMethod]
        public void CountIsCorrect_5()
        {
            ArraySet set = new ArraySet();

            set.Add(new Person { Name = "Alice" });
            set.Add(new Person { Name = "Bob" });
            set.Add(new Person { Name = "Charlie" });
            set.Add(new Person { Name = "Dolan" });
            set.Add(new Person { Name = "Gooby" });

            Assert.AreEqual(5, set.Count());
        }

        [TestMethod]
        public void CountIsCorrect_10K()
        {
            ArraySet set = new ArraySet();

            for (int i = 0; i < 10000; i++)
            {
                set.Add(new Person { Name = $"Alice_{i}" });
            }

            Assert.AreEqual(10000, set.Count());
        }

        [TestMethod]
        public void AddingPersonMultipleTimesDoesNotChangeCount()
        {
            ArraySet set = new ArraySet();

            var alice = new Person { Name = "Alice" };
            set.Add(alice);
            set.Add(alice);

            Assert.AreEqual(1, set.Count());
        }

        [TestMethod]
        public void AddingMultiplePeopleMultipleTimesDoesNotChangeCount()
        {
            ArraySet set = new ArraySet();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            set.Add(alice);
            set.Add(bob);
            set.Add(alice);
            set.Add(bob);

            Assert.AreEqual(2, set.Count());
        }

        [TestMethod]
        public void AddingAndRemovingPeopleMaintainsCorrectCount()
        {
            ArraySet set = new ArraySet();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };

            Assert.AreEqual(0, set.Count());
            set.Add(alice);
            Assert.AreEqual(1, set.Count());
            set.Add(bob);
            Assert.AreEqual(2, set.Count());
            set.Add(charlie);
            Assert.AreEqual(3, set.Count());

            set.Remove(bob);
            Assert.AreEqual(2, set.Count());
            set.Remove(charlie);
            Assert.AreEqual(1, set.Count());
            set.Remove(alice);
            Assert.AreEqual(0, set.Count());
        }

        [TestMethod]
        public void RemovingMultipleTimesDoesNotChangeCount()
        {
            ArraySet set = new ArraySet();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };

            set.Add(alice);
            set.Add(bob);
            set.Add(charlie);
            Assert.AreEqual(3, set.Count());

            set.Remove(bob);
            set.Remove(bob);
            set.Remove(bob);
            Assert.AreEqual(2, set.Count());
        }

        [TestMethod]
        public void SetReturnsCorrectReferences()
        {
            ArraySet set = new ArraySet();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };

            set.Add(alice);
            set.Add(bob);
            set.Add(charlie);
            Person[] people = set.GetAllPeople();

            Assert.AreEqual(3, people.Length);
            Assert.IsTrue(people.Contains(alice));
            Assert.IsTrue(people.Contains(bob));
            Assert.IsTrue(people.Contains(charlie));
        }

        [TestMethod]
        public void SetReturnsCorrectReferencesWhenPeopleAreRemoved()
        {
            ArraySet set = new ArraySet();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };

            set.Add(alice);
            set.Add(bob);
            set.Add(charlie);
            Person[] people = set.GetAllPeople();

            Assert.AreEqual(3, people.Length);
            Assert.IsTrue(people.Contains(alice));
            Assert.IsTrue(people.Contains(bob));
            Assert.IsTrue(people.Contains(charlie));

            set.Remove(bob);
            people = set.GetAllPeople();

            Assert.AreEqual(2, people.Length);
            Assert.IsTrue(people.Contains(alice));
            Assert.IsTrue(people.Contains(charlie));
        }
    }
}
