using System;

namespace _3.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int personsInCourse = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)persons / personsInCourse);

            Console.WriteLine(courses);
        }
    }
}
