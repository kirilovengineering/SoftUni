using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int orders = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0;
            int days = 0;
            int capsulesCount = 0;
            double orderPrice = 0;
            double totalPrice = 0;
            int counter = 1;

            do
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
                orderPrice = pricePerCapsule * days * capsulesCount;
                totalPrice += orderPrice;
                counter++;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            } while (counter <= orders);
            Console.WriteLine($"Total: ${ totalPrice:F2}");
        }
    }
}
