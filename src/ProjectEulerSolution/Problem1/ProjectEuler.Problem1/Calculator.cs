using System.Linq;

namespace ProjectEuler.Problem1
{
    public class Calculator
    {
        public int Calc(int n) => (n > 0)
            ? Enumerable.Range(1, n - 1)
                .Where(i => i % 3 == 0 || i % 5 == 0)
                .Sum()
            : 0;
    }
}
