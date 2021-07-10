using FluentAssertions;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(7, -5, 2)]
        [InlineData(-7, 5, -2)]
        public void Add_SimpleValuesShouldCalculate(
            int firstNumber, int secondNumber, int result)
        {
            result.Should().Be(Calculator.Add(firstNumber, secondNumber));
        }


    }
}
