using System;

namespace _4Task_CSharp_Exam14112021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumDays = int.Parse(Console.ReadLine());
            double mKilometersFirsday = double.Parse(Console.ReadLine());
            double sumKilometers = 0.0;
            double sum = 0.0;

            sumKilometers = mKilometersFirsday;
            sum = mKilometersFirsday;
            for (int i = 1; i <= nNumDays; i++)
            {
                int percent = int.Parse(Console.ReadLine());
                double percent100 = (double)percent / 100;
                double kmForThgisDay = sumKilometers * percent100;
                sumKilometers += kmForThgisDay;
                sum += sumKilometers;
            }
            if (sum >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(sum - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - sum)} more kilometers");
            }

        }
    }
}
