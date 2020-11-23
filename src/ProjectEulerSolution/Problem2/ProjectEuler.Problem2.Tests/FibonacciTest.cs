using Xunit;

namespace ProjectEuler.Problem2.Tests
{
    public class FibonacciTest
    {
        // 問題本文の「By starting with 1 and 2」に従って、一般的なフィボナッチ数列とは1つずつズレている
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        [InlineData(5, 8)]
        [InlineData(6, 13)]
        [InlineData(7, 21)]
        [InlineData(8, 34)]
        [InlineData(9, 55)]
        public void Value(int n, int expected)
        {
            Assert.Equal(expected, Fibonacci.Value(n));
        }
    }
}
