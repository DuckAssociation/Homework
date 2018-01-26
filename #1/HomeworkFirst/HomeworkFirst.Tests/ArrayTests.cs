using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HomeworkFirst.Tests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void Should_return_negativeOne_when_does_not_find_the_number()
        {
            var result = Program.FirstIntegerIndex(new int[0], 5);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Should_return_index_of_first_occurrence()
        {
            var result = Program.FirstIntegerIndex(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 5);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Should_return_index_of_last_occurrence()
        {
            var result = Program.LastIntegerIndex(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 6);

            Assert.AreEqual(5, result);
        }
    }
}
