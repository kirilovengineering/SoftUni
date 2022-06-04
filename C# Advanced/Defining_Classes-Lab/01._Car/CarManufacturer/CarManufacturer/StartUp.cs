using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car ce = new Car();

            ce.Make = "VW";
            ce.Model = "MK3";
            ce.Year = 1992;

            Console.WriteLine($"Make: {ce.Make}\nMoldel: {ce.Model}\nYear: {ce.Year}");
        }
    }
}
