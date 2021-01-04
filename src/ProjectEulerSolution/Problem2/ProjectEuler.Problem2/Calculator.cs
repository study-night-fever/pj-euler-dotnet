using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem2
{
    internal class Calculator : ICalculator
    {
        public IEnumerable<int> ListFibonaccies(int maxValue)
        {
            for (var n = 1; n < int.MaxValue; n++)
            {
                var value = Fibonacci.Value(n);
                if (value <= maxValue)
                    yield return value;
                else
                    yield break;
            }
        }

        public IEnumerable<int> ListEvenFibonacciValues(int maxValue)
            => ListFibonaccies(maxValue)
                .Where(value => value % 2 == 0);

        public int SumEvenFibonacciValues(int maxValue)
            => ListEvenFibonacciValues(maxValue)
                .Sum();
    }
}
