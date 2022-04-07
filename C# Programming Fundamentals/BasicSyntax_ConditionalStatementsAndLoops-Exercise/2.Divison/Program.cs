using System;

namespace _2.Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num = int.Parse(Console.ReadLine());

            //Action
            //By Default if number is not devisible by anny number we take devider -1
            int divider = -1;

            if (num % 10 == 0)
            {
                divider = 10;
            }
            else if (num % 7 == 0)
            {
                divider = 7;
            }
            else if (num % 6 == 0)
            {
                divider = 6;
            }
            else if (num % 3 == 0)
            {
                divider = 3;
            }
            else if (num % 2 == 0)
            {
                divider = 2;
            }

            //Output
            if (divider == -1)
            {
                Console.WriteLine($"Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }
        }
    }
}
