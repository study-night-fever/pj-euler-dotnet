using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace ProjectEuler.Problem1.Tests
{
    public class CalculatorTest
    {
        private readonly IServiceProvider _provider;

        public CalculatorTest()
        {
            _provider = new Func<IServiceProvider>(() =>
            {
                return new ServiceCollection()
                    .SetupForProblem1()
                    .BuildServiceProvider();
            })();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(10, 23)]
        [InlineData(1000, 233168)]
        public void CalcTest(int n, int expected)
        {
            var calculator = _provider.GetService<ICalculator>();

            Assert.Equal(expected, calculator.Calc(n));
        }
    }
}
