using System;

namespace High_OrderFunction
{
    internal class Program
    {
        // High_OrderFunction (Passing Functions to Method)
        // We can pass Func<T> to methods:

        static void Main(string[] args)
        {
            int Operation(int number, Func<int, int> operation)
            {
                return operation(number);
            }
            //We can use the method like that:
            int a = 5;
            int b = Operation(a, number => number * 5); // 25
            Console.WriteLine(b);
            int c = Operation(a, number => number - 3); // 2
            Console.WriteLine(c);
            int d = Operation(b, number => number % 2); // 1
            Console.WriteLine(d);
        }
    }
}
