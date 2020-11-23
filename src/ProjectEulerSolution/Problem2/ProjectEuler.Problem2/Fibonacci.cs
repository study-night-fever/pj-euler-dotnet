using System.Collections.Generic;

namespace ProjectEuler.Problem2
{
    /// <summary>
    /// フィボナッチ数
    /// </summary>
    public static class Fibonacci
    {
        private static readonly IDictionary<int, int> _cache = new Dictionary<int, int>();

        /// <summary>
        /// フィボナッチ数列の指定位置の値を取得します。
        /// </summary>
        /// <param name="n">n番目</param>
        /// <returns>値</returns>
        public static int Value(int n)
        {
            if (!_cache.ContainsKey(n))
                _cache.Add(n, _Calc(n));

            return _cache[n];
        }

        /// <summary>
        /// 指定した引数のフィボナッチ数列の値を計算します。
        /// </summary>
        /// <param name="n">n番目</param>
        /// <returns>値</returns>
        private static int _Calc(int n) => n switch
        {
            // 問題本文の「By starting with 1 and 2」に従い、一般的なフィボナッチ数の計算と異なる（n=2の時、一般的には1を返す）
            0 => 0,
            1 => 1,
            2 => 2, // irregular
            _ => Value(n - 2) + Value(n - 1),
        };
    }
}
