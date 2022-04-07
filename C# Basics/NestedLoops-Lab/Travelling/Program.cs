using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double expences = double.Parse(Console.ReadLine());
                double savings = 0;

                while (expences > savings)
                {
                    savings += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }


            
        }
    }
}
