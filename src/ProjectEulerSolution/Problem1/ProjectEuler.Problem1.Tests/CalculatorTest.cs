using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
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
        public void Calculate(int n, int expected)
        {
            var calculator = _provider.GetService<ICalculator>();

            Assert.Equal(expected, calculator.Calculate(n));
        }

        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(1, new int[] { })]
        [InlineData(10, new[] { 3, 5, 6, 9 })]
        public void List(int n, IEnumerable<int> expected)
        {
            var calculator = _provider.GetService<ICalculator>();

            Assert.Equal(expected, calculator.List(n));
        }
    }
}
