using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HomeworkSecond.Tests
{
    [TestClass]
    public class ArraySorterTests
    {
        [TestMethod]
        public void GivenArrayIsInitialized_WhenItContainsUnorderedIntElements_ThenItIsAscSorted()
        {
            // Assert.
            var sut = new ArraySorter();
            // Act.
            var result = sut.SortArrayAsc(new[] { 1, 1, 2, 6, 82, 854, 5, 81, 5, 2, 5, 4 });
            // Assert.
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 1, 2, 2, 4, 5, 5, 5, 6, 81, 82, 854 }));
        }

        [TestMethod]
        public void GivenArrayIsInitialized_WhenItContainsUnorderedIntElements_ThenItIsDescSorted()
        {
            // Assert.
            var sut = new ArraySorter();
            // Act.
            var result = sut.SortArrayDesc(new[] { 1, 1, 2, 6, 82, 854, 5, 81, 5, 2, 5, 4 });
            // Assert.
            Assert.IsTrue(result.SequenceEqual(new[] { 854, 82, 81, 6, 5, 5, 5, 4, 2, 2, 1, 1, }));
        }
    }
}
