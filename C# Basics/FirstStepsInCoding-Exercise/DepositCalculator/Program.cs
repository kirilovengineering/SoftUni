using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double Deposit = double.Parse(Console.ReadLine());
            double TermOfTheDeposit = double.Parse(Console.ReadLine());
            double AnualInterestRate = double.Parse(Console.ReadLine());
            //  сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double sum = Deposit + TermOfTheDeposit * ((Deposit * (AnualInterestRate / 100)) / 12);
            Console.WriteLine(sum);

        }
    }
}