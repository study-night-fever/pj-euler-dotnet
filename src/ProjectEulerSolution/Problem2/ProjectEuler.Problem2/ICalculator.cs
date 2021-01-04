using System.Collections.Generic;

namespace ProjectEuler.Problem2
{
    public interface ICalculator
    {
        /// <summary>
        /// 指定した値以下のフィボナッチ数列を取得します。
        /// </summary>
        public IEnumerable<int> ListFibonaccies(int maxValue);

        /// 指定した値以下のフィボナッチ数のうち、偶数値の項のコレクションを返します。
        /// </summary>
        public IEnumerable<int> ListEvenFibonacciValues(int maxValue);

        /// 指定した値以下のフィボナッチ数のうち、偶数値の項の総和を返します。
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public int SumEvenFibonacciValues(int maxValue);
    }
}
