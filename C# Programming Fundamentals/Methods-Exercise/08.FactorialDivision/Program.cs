using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstFactorialN = int.Parse(Console.ReadLine());
            int secondFactorialN = int.Parse(Console.ReadLine());

            double firstFactorial = Factorial(firstFactorialN);
            double secondFactorial = Factorial(secondFactorialN);

            double divideFirstFactBySecondFact = firstFactorial / secondFactorial;
            Console.WriteLine($"{divideFirstFactBySecondFact:F2}");

        }

        public static double Factorial(double FactorialNumber)
        {
         
            if (FactorialNumber == 1)
            {
                return 1;
            }

            return FactorialNumber * Factorial(FactorialNumber - 1);
        }
    }
}
