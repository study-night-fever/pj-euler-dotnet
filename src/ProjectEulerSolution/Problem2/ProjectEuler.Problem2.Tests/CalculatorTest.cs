using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Xunit;

namespace ProjectEuler.Problem2.Tests
{
    public class CalculatorTest
    {
        private readonly IServiceProvider _provider;

        public CalculatorTest()
        {
            _provider = new Func<IServiceProvider>(() =>
            {
                return new ServiceCollection()
                    .SetupForProblem2()
                    .BuildServiceProvider();
            })();
        }

        [Theory]
        [InlineData(1, new[] { 1 })]
        [InlineData(10, new[] { 1, 2, 3, 5, 8 })]
        [InlineData(100, new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 })]
        public void ListFibonaccies(int maxValue, IEnumerable<int> expected)
        {
            var calculator = _provider.GetService<ICalculator>();
            Assert.Equal(expected, calculator.ListFibonaccies(maxValue));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(10, 2 + 8)]
        [InlineData(100, 2 + 8 + 34)]
        public void SumEvenFibonacciValues(int maxValue, int expected)
        {
            var calculator = _provider.GetService<ICalculator>();
            Assert.Equal(expected, calculator.SumEvenFibonacciValues(maxValue));
        }
    }
}
