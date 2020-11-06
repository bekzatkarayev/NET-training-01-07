using NUnit.Framework;
using Task03;

namespace Task03.Tests
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindElementOfBalancedArray_SampleInputs_ReturnsCorrectValue()
        {
        
            // Arrange
            int? expected, actual;
            decimal[] numbers = new decimal[] { 1.25M, 17.456M, -2.36M, -41.2M, 4.2M, 1.11M, 6.8M, -19.544M };

            // Act
            expected = 6;
            actual = Program.FindElementOfBalancedArray(ref numbers);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}