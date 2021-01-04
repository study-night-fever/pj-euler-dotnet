using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem1
{
    internal class Calculator : ICalculator
    {
        public int Calculate(int n) => List(n).Sum();

        public IEnumerable<int> List(int n) => (n > 0)
            ? Enumerable.Range(1, n - 1)
                .Where(i => i % 3 == 0 || i % 5 == 0)
            : Enumerable.Empty<int>();
    }
}
