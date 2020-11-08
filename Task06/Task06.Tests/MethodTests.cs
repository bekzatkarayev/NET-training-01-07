using NUnit.Framework;
using System;
using Task06;

namespace Task06.Tests
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, new[] { 5, 11, 13, 35, 47 }, ExpectedResult = new[] { 13, 35 })]
        [TestCase(7, new[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, ExpectedResult = new[] { 7, 7, 70, 17 })]
        [TestCase(3, new[] { 11, 72, 245 }, ExpectedResult = new int[]{})]
        [TestCase(8, new[] { 827, 223, 343, 983, 168, 267, 100, 868, 302, 531 }, ExpectedResult = new[] { 827, 983, 168, 868 })]
        [TestCase(9, new[] { 86, 981, 396, 755, 434, 224, 367, 854, 539, 622 }, ExpectedResult = new[] { 981, 396, 539 })]
        [TestCase(3, new[] { 570, 2, 51, 59, 348, 33, 301, 912, 955, 317 }, ExpectedResult = new[] { 348, 33, 301, 317 })]
        [TestCase(5, new[] { 538, 878, 783, 53, 43, 26, 104, 47, 180, 700 }, ExpectedResult = new[] { 538, 53 })]
        [TestCase(2, new[] { 758, 757, 435, 846, 358, 173, 851, 201, 63, 380 }, ExpectedResult = new[] { 201 })]

        public int[] FilterDigit_SampleInput_ReturnsCorrectArray(int digit, int[] numbers)
        {
            // Arrange


            // Act


            // Assert
            return Program.FilterDigit(digit, ref numbers);
        }
    }
}