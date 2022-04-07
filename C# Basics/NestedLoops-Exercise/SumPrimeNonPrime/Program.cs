using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            int intNumber = 0;
            int sumPrime = 0;
            int sumNonPrime = 0;
            double flag = 0;
            int stackPrime = 0;
            int stackNonPrime = 0;

            number = Console.ReadLine();
            while (number != "stop")
            {
                intNumber = int.Parse(number);

                if (intNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    intNumber = 0;
                }
                if (intNumber == 0)
                {
                    sumNonPrime += 0;
                }

                for (int i = 2; i < intNumber - 1 ; i++)
                {
                    flag = intNumber % i;
                    if (intNumber > 1 && flag == 0)
                    {
                        stackPrime += 1;
                    }
                    else
                    {
                        stackNonPrime += 1;
                    }
                }
                if (stackPrime == 0)
                {
                    sumPrime += intNumber;
                }
                else
                {
                    sumNonPrime += intNumber;
                }
                stackPrime = 0;
                stackNonPrime = 0;
                number = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
