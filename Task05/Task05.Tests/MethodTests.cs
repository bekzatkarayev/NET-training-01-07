using System;
using System.Diagnostics;
using NUnit.Framework;
using Task05;

namespace Task05.Tests
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int FindNextBiggerNumber_SampleInput_ReturnsCorrectValue(int number)
        {
            // Arrange
            int actual;

            // Act
            actual = Program.FindNextBiggerNumber(number, out _);

            // Assert
            return actual;
        }

        [Test]
        [TestCase(12)]
        [TestCase(513)]
        [TestCase(2017)]
        [TestCase(414)]
        [TestCase(144)]
        [TestCase(1234321)]
        [TestCase(1234126)]
        [TestCase(3456432)]
        [TestCase(10)]
        [TestCase(20)]
        public void FindNextBiggerNumber_SampleInput_ExecutionTimeLessThan10ms(int number)
        {
            // Arrange
            TimeSpan allowedTime = new TimeSpan(0, 0, 0, 0, 10);  

            // Act
            Program.FindNextBiggerNumber(number, out TimeSpan executionTime);

            // Assert
            Assert.GreaterOrEqual(allowedTime, executionTime);
        }
    }
}