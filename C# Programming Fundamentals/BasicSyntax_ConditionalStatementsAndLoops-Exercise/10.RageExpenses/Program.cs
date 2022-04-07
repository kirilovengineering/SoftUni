using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double loses = double.Parse(Console.ReadLine()), total = 0;
            double headsetPrice = double.Parse(Console.ReadLine()), headsetsTrashed = Math.Floor(loses / 2);
            double mousePrice = double.Parse(Console.ReadLine()), trashedMouses = Math.Floor(loses / 3);
            double keyboardPrice = double.Parse(Console.ReadLine()), keybordsTrashed = 0;
            double displayPrice = double.Parse(Console.ReadLine()), displaysTrashed = 0; int counter = 0;

            for (int i = 0; i <= loses; i += 1)
            {
                
                if (i % 3 == 0 && i % 2 == 0 && i != 0)
                {
                    keybordsTrashed++;
                    counter++;
                }
                
                if (counter == 2 && keybordsTrashed != 0)
                {
                    displaysTrashed++;
                    counter = 0;
                }
            }
            total = headsetPrice * headsetsTrashed + mousePrice * trashedMouses + keybordsTrashed * keyboardPrice + displaysTrashed * displayPrice;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
