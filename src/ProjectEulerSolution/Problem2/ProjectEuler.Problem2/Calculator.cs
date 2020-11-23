using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem2
{
    public class Calculator
    {
        /// <summary>
        /// 指定した値以下のフィボナッチ数のうち、偶数値の項の総和を返します。
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public int SumEvenFibonacciValues(int maxValue)
            => ListFibonaccies(maxValue)
                .Where(value => value % 2 == 0)
                .Sum();

        /// <summary>
        /// 指定した値以下のフィボナッチ数列を取得します。
        /// </summary>
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
    }
}
