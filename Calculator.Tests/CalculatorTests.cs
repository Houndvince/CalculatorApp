using FluentAssertions;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(21, 5.25, 26.25)]
        public void Add_SimpleValuesShouldCalculate(
            double firstNumber, double secondNumber, double result)
        {
            result.Should().Be(Calculate.Add(firstNumber, secondNumber));
        }
    }
}
