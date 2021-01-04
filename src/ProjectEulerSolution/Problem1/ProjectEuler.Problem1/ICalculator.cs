using System.Collections.Generic;

namespace ProjectEuler.Problem1
{
    public interface ICalculator
    {
        public int Calculate(int n);

        public IEnumerable<int> List(int n);
    }
}
