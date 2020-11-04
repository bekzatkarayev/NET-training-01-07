using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task01;

namespace Task01.MSTestTests
{
    [TestClass]
    public class MethodTests
    {
        [DataTestMethod]
        [DataRow(15, 15, 0, 0, 15)]
        [DataRow(8, 15, 0, 0, 9)]
        [DataRow(8, 15, 3, 8, 120)]
        [DataRow(2, 2, 0, 0, 3)]
        [DataRow(2, 2, 3, 3, 10)]
        [DataRow(2, 2, 2, 3, 10)]
        [DataRow(2, 2, 3, 6, 18)]
        [DataRow(2, 2, 1, 2, 4)]
        [DataRow(12, 5, 0, 0, 13)]
        [DataRow(12, 5, 5, 7, 172)]
        [DataRow(12, 5, 1, 3, 10)]
        [DataRow(5, 25, 0, 1, 7)]
        [DataRow(5, 25, 2, 5, 49)]
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
