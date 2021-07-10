using FluentAssertions;
using Xunit;

namespace CalculatorLibrary
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        public void Add_SimpleValuesShouldCalculate(
            double firstNumber, double secondNumber, double result)
        {
            Assert.Equal(result, Calculator.Add(firstNumber, secondNumber));
            result.Should().Be(Calculator.Add(firstNumber, secondNumber));
        }

    }
}
