using FluentAssertions;
using Xunit;

namespace Calculator.Library
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5.25, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(
            double firstNumber, double secondNumber, double result)
        {
            result.Should().Be(Calculate.Add(firstNumber, secondNumber));
        }

        [Theory]
        [InlineData(3, 4, -1)]
        [InlineData(14, 3.5, 10.5)]
        [InlineData(double.MaxValue, 5.25, double.MaxValue)]
        public void Substract_SimpleValuesShouldCalculate(
            double firstNumber, double secondNumber, double result)
        {
            result.Should().Be(Calculate.Substract(firstNumber, secondNumber));
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(2, -3.5, -7)]
        public void Multiply_SimpleValuesShouldCalculate(
            double firstNumber, double secondNumber, double result)
        {
            result.Should().Be(Calculate.Multiply(firstNumber, secondNumber));
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(-10, 5, -2)]
        public void Divide_SimpleValuesShouldCalculate(
            double firstNumber, double secondNumber, double result)
        {
            result.Should().Be(Calculate.Divide(firstNumber, secondNumber));
        }

        [Fact]
        public void Divide_DivideByZero_ShouldThrowException()
        {
            // Arrange
            double firstNumber = 5;
            double secondNumber = 0;

            // Act
            double actual = Calculate.Divide(firstNumber, secondNumber);

            // Assert
            actual.Should().Be(0);
        }
    }
}
