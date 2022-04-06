using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minetExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minetArrive = int.Parse(Console.ReadLine());

            int sumExamMinet = 0;
            int sumArriveMinet = 0;
            int difference = 0;
            int addZero = 0;

            sumExamMinet = hourExam * 60 + minetExam;
            sumArriveMinet = hourArrive * 60 + minetArrive;

            difference = sumExamMinet - sumArriveMinet;
            addZero = Math.Abs(difference % 60);

            if ((difference >= 0) && (difference <= 30))
            {
                Console.WriteLine("On time");
                if (difference != 0)
                {
                    if ((Math.Abs(difference) / 60) < 1)
                    {
                        Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
                    }
                    else
                    {
                        if (addZero < 10)
                        {
                            Console.WriteLine($"{Math.Abs(difference) / 60}:0{Math.Abs(difference) % 60} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{Math.Abs(difference) / 60}:{Math.Abs(difference) % 60} hours before the start");
                        }
                    }
                }

            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                if ((Math.Abs(difference) / 60) < 1)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
                }
                else
                {
                    if (addZero < 10)
                    {
                        Console.WriteLine($"{Math.Abs(difference) / 60}:0{Math.Abs(difference) % 60} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Abs(difference) / 60}:{Math.Abs(difference) % 60} hours before the start");
                    }
                }
            }
            else if (difference < 0)
            {
                Console.WriteLine("Late");
                if ((Math.Abs(difference) / 60) < 1)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else
                {
                    if (addZero < 10)
                    {
                        Console.WriteLine($"{Math.Abs(difference) / 60}:0{Math.Abs(difference) % 60} hours after the start");
                    }
                    {
                        Console.WriteLine($"{Math.Abs(difference) / 60}:{Math.Abs(difference) % 60} hours after the start");
                    }
                }
            }
        }
    }
}
