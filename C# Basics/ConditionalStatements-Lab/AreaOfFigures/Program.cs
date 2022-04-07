using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();


            if (figure == ("square"))
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine( "{0:F3}", a * a );
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine( "{0:F3}", a * b );
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine( "{0:F3}", Math.PI * Math.Pow(r, 2));
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                Console.WriteLine( "{0:F3}", (a * ha) / 2 );
            }
        }
    }
}
