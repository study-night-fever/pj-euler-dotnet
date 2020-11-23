using Xunit;

namespace ProjectEuler.Problem1.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(10, 23)]
        [InlineData(1000, 233168)]
        public void CalcTest(int n, int expected)
        {
            var calculator = new Calculator();

            Assert.Equal(expected, calculator.Calc(n));
        }
    }
}
