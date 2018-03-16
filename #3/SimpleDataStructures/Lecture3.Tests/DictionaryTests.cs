using Lecture3.Dictionary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture3.Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void CountIsCorrect_0()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            Assert.AreEqual(0, dictionary.Count());
        }

        [TestMethod]
        public void CountIsCorrect_5()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            dictionary.Add("Alice", new Person { Name = "Alice" });
            dictionary.Add("Bob", new Person { Name = "Bob" });
            dictionary.Add("Charlie", new Person { Name = "Charlie" });
            dictionary.Add("Dolan", new Person { Name = "Dolan" });
            dictionary.Add("Gooby", new Person { Name = "Gooby" });

            Assert.AreEqual(5, dictionary.Count());
        }

        [TestMethod]
        public void CountIsCorrect_10K()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            for (int i = 0; i < 10000; i++)
            {
                dictionary.Add($"Alice_{i}", new Person { Name = $"Alice_{i}" });
            }

            Assert.AreEqual(10000, dictionary.Count());
        }

        public void ContainsReturnsCorrectResult_Empty()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            Assert.IsFalse(dictionary.ContainsKey("Alice"));
            Assert.IsFalse(dictionary.ContainsKey("Bob"));
            Assert.IsFalse(dictionary.ContainsKey("Charlie"));
            Assert.IsFalse(dictionary.ContainsKey("Dolan"));
            Assert.IsFalse(dictionary.ContainsKey("Gooby"));
        }

        public void ContainsReturnsCorrectResult_NonEmpty()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };
            var dolan = new Person { Name = "Dolan" };
            var gooby = new Person { Name = "Gooby" };
            dictionary.Add("Alice", alice);
            dictionary.Add("Bob", bob);
            dictionary.Add("Charlie", charlie);
            dictionary.Add("Dolan", dolan);
            dictionary.Add("Gooby", gooby);

            Assert.IsTrue(dictionary.ContainsKey("Alice"));
            Assert.IsTrue(dictionary.ContainsKey("Bob"));
            Assert.IsTrue(dictionary.ContainsKey("Charlie"));
            Assert.IsTrue(dictionary.ContainsKey("Dolan"));
            Assert.IsTrue(dictionary.ContainsKey("Gooby"));
        }

        public void GetReturnsCorrectPerson()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };
            var dolan = new Person { Name = "Dolan" };
            var gooby = new Person { Name = "Gooby" };
            dictionary.Add("Alice", alice);
            dictionary.Add("Bob", bob);
            dictionary.Add("Charlie", charlie);
            dictionary.Add("Dolan", dolan);
            dictionary.Add("Gooby", gooby);

            Assert.AreSame(alice, dictionary.GetByKey("Alice"));
            Assert.AreSame(bob, dictionary.GetByKey("Bob"));
            Assert.AreSame(charlie, dictionary.GetByKey("Charlie"));
            Assert.AreSame(dolan, dictionary.GetByKey("Dolan"));
            Assert.AreSame(alice, dictionary.GetByKey("Gooby"));
        }

        public void PersonIsNotContainedInDictionaryAfterRemoval()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };
            var dolan = new Person { Name = "Dolan" };
            var gooby = new Person { Name = "Gooby" };
            dictionary.Add("Alice", alice);
            dictionary.Add("Bob", bob);
            dictionary.Add("Charlie", charlie);
            dictionary.Add("Dolan", dolan);
            dictionary.Add("Gooby", gooby);

            dictionary.RemoveByKey("Alice");
            dictionary.RemoveByKey("Bob");
            dictionary.RemoveByKey("Charlie");

            Assert.IsFalse(dictionary.ContainsKey("Alice"));
            Assert.IsFalse(dictionary.ContainsKey("Bob"));
            Assert.IsFalse(dictionary.ContainsKey("Charlie"));
            Assert.IsTrue(dictionary.ContainsKey("Dolan"));
            Assert.IsTrue(dictionary.ContainsKey("Gooby"));
        }

        public void CountIsMaintenedCorrectlyWhenPeopleAreAddedAndRemoved()
        {
            ArrayDictionary dictionary = new ArrayDictionary();

            var alice = new Person { Name = "Alice" };
            var bob = new Person { Name = "Bob" };
            var charlie = new Person { Name = "Charlie" };
            var dolan = new Person { Name = "Dolan" };
            var gooby = new Person { Name = "Gooby" };
            dictionary.Add("Alice", alice);
            dictionary.Add("Bob", bob);
            dictionary.Add("Charlie", charlie);
            dictionary.Add("Dolan", dolan);
            dictionary.Add("Gooby", gooby);

            Assert.AreEqual(5, dictionary.Count());
            dictionary.RemoveByKey("Alice");
            Assert.AreEqual(4, dictionary.Count());
            dictionary.RemoveByKey("Bob");
            Assert.AreEqual(3, dictionary.Count());
            dictionary.RemoveByKey("Charlie");
            Assert.AreEqual(2, dictionary.Count());
        }
    }
}
