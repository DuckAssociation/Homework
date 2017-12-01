using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeworkFirst.Tests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void GivenArrayClassIsInitialized_WhenArrayContainsIntegers_ThenWeCanFindIndexOfPassedInInteger()
        {
            // Assert.
            var sut = new IntegerFinder(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 1);
            // Act.
            var result = sut.IntegerIndex();
            // Assert.
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GivenArrayClassIsInitialized_WhenArrayContainsIntegers_ThenWeCanFindIndexOfFirstPassedInInteger()
        {
            // Assert.
            var sut = new IntegerFinder(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 5);
            // Act.
            var result = sut.IntegerIndex();
            // Assert.
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GivenArrayClassIsInitialized_WhenArrayContainsIntegers_ThenWeCanFindIndexOfLastPassedInInteger()
        {
            // Assert.
            var sut = new IntegerFinder(new[] { 1, 5, 6, 8, 1, 6, 3, 5, 1, 2, 5 }, 6);
            // Act.
            var result = sut.IntegerIndex();
            // Assert.
            Assert.AreEqual(4, result);
        }
    }
}
