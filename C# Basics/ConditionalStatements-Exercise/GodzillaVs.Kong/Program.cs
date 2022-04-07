using System;

namespace GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double budgetFilm = double.Parse(Console.ReadLine());
            int numberOfTheStatists = int.Parse(Console.ReadLine());
            double priceWearPerStatist = double.Parse(Console.ReadLine());

            double decor = budgetFilm * 0.1;
            double totalSumWears = priceWearPerStatist * numberOfTheStatists;
            double totalSumFilm = totalSumWears + decor;

            if (numberOfTheStatists >= 150)
            {
                totalSumWears = totalSumWears - (totalSumWears * 0.1);
            }
            totalSumFilm = totalSumWears + decor;

            if (totalSumFilm > budgetFilm)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budgetFilm - totalSumFilm):F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budgetFilm - totalSumFilm):F2} leva left.");
            }
        }
    }
}