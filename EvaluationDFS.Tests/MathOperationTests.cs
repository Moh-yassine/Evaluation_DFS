using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaluationDFS.Tests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var math = new MathOperations();

            // Act
            var result = math.Add(3, 7);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            var math = new MathOperations();

            // Act
            var result = math.Add(10, -4);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            var math = new MathOperations();

            // Act
            var result = math.Divide(10, 2);

            // Assert
            Assert.AreEqual(5.0f, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Divide_DivideByZero_ThrowsException()
        {
            // Arrange
            var math = new MathOperations();

            // Act
            math.Divide(10, 0); // Doit lever une exception
        }

        [TestMethod]
        public void GetOddNumbers_LimitIsTen_ReturnsOddNumbers()
        {
            // Arrange
            var math = new MathOperations();

            // Act
            var result = math.GetOddNumbers(10);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5, 7, 9 }, result.ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetOddNumbers_NegativeLimit_ThrowsException()
        {
            // Arrange
            var math = new MathOperations();

            // Act
            math.GetOddNumbers(-5); // Doit lever une exception
        }
    }
}
