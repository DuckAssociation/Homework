using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericIterator;

namespace GenericIterator.Tests
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void CanEnumerate()
        {
            // Arrange.
            var sut = new Factory<Elf>();
            sut.EmployWorker(new Elf());
            // Act.
            foreach (var employee in sut)
            {
                // Assert.
            }
        }

        [TestMethod]
        public void DoesEnumerationCorrectly()
        {
            // Arrange.
            var sut = new Factory<Elf>();
            sut.EmployWorker(new Elf());

            // Act.
            foreach (var employee in sut)
            {
                // Assert.
                Assert.AreEqual("Elf", employee.ToString());
                break;
            }
        }

        [TestMethod]
        public void DoesProvideSmurfName()
        {
            // Arrange.
            var sut = new Factory<Smurf>();
            sut.EmployWorker(new Smurf());

            // Act.
            foreach (var employee in sut)
            {
                // Assert.
                Assert.AreEqual("Smurf", employee.ToString());
                break;
            }
        }


        [TestMethod]
        public void DoesEnumerationThroughAllCollection()
        {
            // Arrange.
            var sut = new Factory<Elf>();
            int workerCount = 6;
            for (int i = 0; i < workerCount; i++)
                sut.EmployWorker(new Elf());
            var count = 0;
            
            // Act.
            foreach (var employee in sut)
                count++;

            // Assert.
            Assert.AreEqual(workerCount, count);
        }
    }
}
