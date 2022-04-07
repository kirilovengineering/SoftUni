using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            double sum = 0;
            double odd = 0;

            int giftEven = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + (giftEven - 1);
                    giftEven += 10;
                }
                else
                {
                    odd++;
                }
            }
            double total = sum + (priceToy * odd);
            if (total >= priceWashMachine)
            {
                Console.WriteLine($"Yes! {(total - priceWashMachine):F2}");
            }
            else if (total < priceWashMachine)
            {
                Console.WriteLine($"No! {(priceWashMachine - total):F2}");
            }
        }
    }
}
