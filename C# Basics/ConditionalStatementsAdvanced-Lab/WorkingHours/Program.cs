using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if ((hour >= 10 && hour <= 18) && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }
            if ((hour >= 10 && hour <= 18) && (day == "Sunday"))
            {
                Console.WriteLine("closed");
            }
            if ((hour >= 0 && hour < 10 || hour > 18 && hour <= 24) && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday"))
            {
                Console.WriteLine("closed");
            }
        }
    }
}
