using System;

namespace _2Task_CSharp_Exam14112021
{
    class Program
    {
        static void Main(string[] args)
        {
            double loveMessage = 0.60;
            double vaxRose = 7.20;
            double keyHolder = 3.60;
            double cartoonPic = 18.20;
            double luckSurprise = 22;

            double priceParty = double.Parse(Console.ReadLine());
            int nloveMessage = int.Parse(Console.ReadLine());
            int nvaxRose = int.Parse(Console.ReadLine());
            int nkeyHolder = int.Parse(Console.ReadLine());
            int ncartoonPic = int.Parse(Console.ReadLine());
            int nluckSurprise = int.Parse(Console.ReadLine());

            double sum = (loveMessage * nloveMessage) + (vaxRose * nvaxRose) + (keyHolder * nkeyHolder) + (cartoonPic * ncartoonPic) + (luckSurprise * nluckSurprise);
            int numberProdukts = nloveMessage + nvaxRose + nkeyHolder + ncartoonPic + nluckSurprise;

            if (numberProdukts >= 25)
            {
                double discount = sum * 0.35;
                sum -= discount; ;
            }

            double hostCost = sum * 0.10;
            sum -= hostCost;
            

            if (sum >= priceParty)
            {
                sum -= priceParty;
                Console.WriteLine($"Yes! {sum:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceParty - sum:F2} lv needed.");
            }
        }
    }  
}