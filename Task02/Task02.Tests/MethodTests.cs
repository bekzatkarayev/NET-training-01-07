using System;
using NUnit.Framework;
using Task02;

namespace Task02.Tests
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(-2)]
        [TestCase(3, 1, 3)]
        [TestCase(-929, 377, -218, 666, 636, -437, -308, -271, 952, -509)]
        [TestCase(33, -93, -634, 143, -997, 159, -751, 514, 252)]
        [TestCase(668, 32, 858, -220, -70, -641, -565, -292)]
        [TestCase(756, 752, -976, 61, 200, 785, -286)]
        public void FindMax_SampleInput_ReturnsCorrectValue(params int[] numbers)
        {
            // Arrange
            int expected, actual;

            // Act
            actual = Program.FindMax(ref numbers);
            Array.Sort(numbers);
            expected = numbers[^1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}