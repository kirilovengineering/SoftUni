using System;

namespace High_OrderFunctionMoreExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            long Aggregate(int start, int end, Func<long, long, long> op)
            {
                long result = start;
                for (int i = start + 1; i <= end; i++)
                {
                    result = op(result, i);
                }
                return result;

            }

            Console.WriteLine(Aggregate(1, 10, (a, b) => a + b)); // 55
            Console.WriteLine(Aggregate(1, 10, (a, b) => a * b)); // 3628800
            Console.WriteLine(Aggregate(1, 10, (a, b) => long.Parse("" + a + b))); // 12345678910
        }
    }
}
