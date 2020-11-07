using NUnit.Framework;
using Task04;

namespace NUnitTestProject1
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("bluery", "blue", "berry")]
        [TestCase("abcd", "ab", "cd")]
        [TestCase("flower", "", "flower")]
        [TestCase("", "", "")]
        [TestCase("ALBERTrobets", "ALBERT", "roberts")]
        [TestCase("EgOnoNak", "EgOn", "oNgEak")]
        [TestCase("Clarishe", "Clarissa", "Charles")]
        [TestCase("Vandium ChlorePtsg", "Vanadium Chloride", "Potassium Permanganate")]
        public void ConcatenateStringsWithoutRepeat_SampleInput_ReturnsCorrectValue(string result, string str1, string str2)
        {
            // Arrange
            string expected, actual;

            // Act
            expected = result;
            actual = Program.ConcatenateStringsWithoutRepeat(str1, str2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}