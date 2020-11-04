using NUnit.Framework;
using Task01;

namespace Task01.NUnitTests
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(15, 15, 0, 0, 15)]
        [TestCase(8, 15, 0, 0, 9)]
        [TestCase(8, 15, 3, 8, 120)]
        [TestCase(2, 2, 0, 0, 3)]
        [TestCase(2, 2, 3, 3, 10)]
        [TestCase(2, 2, 2, 3, 10)]
        [TestCase(2, 2, 3, 6, 18)]
        [TestCase(2, 2, 1, 2, 4)]
        [TestCase(12, 5, 0, 0, 13)]
        [TestCase(12, 5, 5, 7, 172)]
        [TestCase(12, 5, 1, 3, 10)]
        [TestCase(5, 25, 0, 1, 7)]
        [TestCase(5, 25, 2, 5, 49)]
        public void InsertNumber_SampleInput_ReturnsCorrectValue(int a, int b, int i, int j, int c)
        {
            // Arrange
            int expected = c;
            // Act
            int actual = Program.InsertNumber(a, b, i, j);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}