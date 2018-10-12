using Ch05_Calculator;
using System;
using Xunit;

namespace Ch05_CalculatorUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            // Arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();

            // Act
            double actual = calc.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}