using System;

namespace ProjectEuler.Problem2.App
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 1 && int.TryParse(args[0], out var n))
            {
                var calculator = new Calculator();
                var result = calculator.SumEvenFibonacciValues(n);

                Console.WriteLine($"Result: {result:#,##0}");
            }
        }
    }
}
