using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CalculatorPrototype.Controllers;
using CalculatorLibrary;

namespace CalculatorPrototype.Tests
{
    public class CalculatorTests
    {
        [Test]
        [TestCase (4, 4, 8)]
        [TestCase (5, 4, 10)]
        [TestCase (0, 0, 0)]
        public void AdditionTest(int firstInput, int secondInput, int expectedResult)
        {
            //Arrange
            ICalculation calculator = new Calculator();
            //Act
            decimal realResult = calculator.Addition(firstInput, secondInput);
            //Assert
            Assert.AreEqual(expectedResult, realResult);
        }
    }
}