using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
//            Да се напише програма, която чете час и минути от 24 - часово денонощие, въведени от потребителя и
//изчислява колко ще е часът след 15 минути.Резултатът да се отпечата във формат часове: минути.Часовете
//винаги са между 0 и 23, а минутите винаги са между 0 и 59.Часовете се изписват с една или две цифри.
//Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.

            int hours = int.Parse(Console.ReadLine());
            int minets = int.Parse(Console.ReadLine());

            int hoursInMinets = hours * 60;

            hoursInMinets = hoursInMinets + minets + 15;

            if (hoursInMinets <= 1440)
            {
                hours = hoursInMinets / 60;
                minets = hoursInMinets % 60;

                if (minets < 10)
                {
                    if (hours == 24) { hours = 0;}
                    Console.WriteLine($"{hours}:0{minets}");
                }
                else
                {
                    if (hours == 24) { hours = 0;}
                    Console.WriteLine($"{hours}:{minets}");
                }
            }
            else if (hoursInMinets > 1440)
            {
                hours = hoursInMinets / 60;
                minets = hoursInMinets % 60;


                if (minets < 10)
                {

                    if (hours == 24) { hours = 0;}
                    Console.WriteLine($"{hours}:0{minets}");
                }
                else
                {
                    if (hours == 24) { hours = 0;}
                    Console.WriteLine($"{hours}:{minets}");
                }
            }
        }
    }
}
