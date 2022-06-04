using System;

namespace StaticClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // членовете в такъв клас не могат да се инстанцират,
            // т.е. те имат само едно копие,
            // еетествено класовете имата по много копия,
            // Пример класът Car може да има BMW, Mercedes и т.н.
            // Пример за статични класове и тяхния смисъл е да няма разновидности е:
            double pi = Math.PI; // има едно единствено пи в математиката, статична константа
            double sqrt = Math.Sqrt(4); // има един единствен корен квадратен
            double roudedNumber = Math.Round(pi); // статичен метод
            Console.WriteLine(pi);
            Console.WriteLine(sqrt);
            Console.WriteLine(roudedNumber);
        }
    }
}
