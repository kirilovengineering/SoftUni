using System;

namespace Override_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car

            //{
            //    Make = "WV",
            //    Model = "Passat",
            //    PowerHorse = "103",
            //    RegistrationNumber = "RZ 5643 DDS"
            //};

            Car carcar = new Car("WV", "Passat", "103", "RZ 5643 DDS");

            Console.WriteLine(carcar.ToString());
        }
    }
}
