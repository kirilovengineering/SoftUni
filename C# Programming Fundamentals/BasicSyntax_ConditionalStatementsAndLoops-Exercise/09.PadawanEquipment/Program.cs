using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()), total = 0;

            double students = double.Parse(Console.ReadLine());

            double lightsaber = double.Parse(Console.ReadLine()), lightsaberInMind = Math.Ceiling(students * 1.1);

            double robe = double.Parse(Console.ReadLine());

            double belt = double.Parse(Console.ReadLine()), freeBelts = Math.Floor(students / 6);

            double beltTotal = (students - freeBelts) * belt, lightsaberTotal = lightsaber * lightsaberInMind;

            total = beltTotal + lightsaberTotal + (students * robe);

            if (budget >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - budget:f2}lv more.");
            }
        }
    }
}
