using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {

            //            4.Магазин за детски играчки
            //           Петя има магазин за детски играчки.Тя получава голяма поръчка, която трябва да изпълни.С парите, които
            //ще спечели иска да отиде на екскурзия.
            //Цени на играчките:
            // Пъзел - 2.60 лв.
            // Говореща кукла -3 лв.
            // Плюшено мече -4.10 лв.
            // Миньон - 8.20 лв.
            // Камионче - 2 лв.
            //Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25 % от общата цена. От спечелените
            //пари Петя трябва да даде 10 % за наема на магазина.Да се пресметне дали парите ще ѝ стигнат да отиде на
            //екскурзия.
            //Вход
            //От конзолата се четат 6 реда:
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            //Изход
            //На конзолата се отпечатва:
            // Ако парите са достатъчни се отпечатва:
            //o & quot; Yes! { оставащите пари}
            //            lv left.&quot;
            // Ако парите НЕ са достатъчни се отпечатва:
            //            o & quot; Not enough money! { недостигащите пари}
            //            lv needed.&quot;
            //            Резултатът трябва да се форматира до втория знак след десетичната запетая.

            const double pricePuzzle = 2.60;
            const double priceTalkingDoll = 3.00;
            const double priceTeddyBear = 4.10;
            const double priceMinion = 8.20;
            const double priceTruck = 2.00;

            double priceOfTheTrip = double.Parse(Console.ReadLine());

            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double totalSum = (pricePuzzle * numberOfPuzzles +
                priceTalkingDoll * numberOfTalkingDolls +
                priceTeddyBear * numberOfTeddyBears +
                priceMinion * numberOfMinions +
                priceTruck * numberOfTrucks);

            int numberToys = (numberOfPuzzles +
                numberOfTalkingDolls +
                numberOfTeddyBears +
                numberOfMinions +
                numberOfTrucks);

            double discount = totalSum * 0.25;

            if (numberToys >= 50) 
            {
                totalSum = totalSum - discount;
            }

            double rent = totalSum * 0.1;
            double profit = (totalSum - rent) ;
            double neededMony = ( priceOfTheTrip - profit );

            if (profit >= priceOfTheTrip)
            {
                Console.WriteLine($"Yes! {(profit - priceOfTheTrip):F2} lv left.");
            }
            else
            {

                Console.WriteLine($"Not enough money! {(neededMony):F2} lv needed.");
            }


        }
    }
}
