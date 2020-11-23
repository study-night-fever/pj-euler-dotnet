using System;

namespace ProjectEuler.Problem1.App
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 1 && int.TryParse(args[0], out var n))
            {
                var calculator = new Calculator();
                var result = calculator.Calc(n);

                Console.WriteLine($"n:{n}, result:{result}");
            }
        }
    }
}
