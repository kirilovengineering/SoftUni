using System;

namespace DelegateWhatIs
{
    //Дефинираме като клас, в C# тип данни който съдържа метод с определени параметри и връща типа
    // в случая приема x y и връща int
    //Казваме Делегата Aggregat връща int 
    // Делегата е call back method - метод извиква друг метод като параметър 
    public delegate int Aggregate(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Aggregate multiplay = (x,y) => x * y;
            Aggregate devide = (x, y) => x / y;
            Aggregate add = (x, y) => x + y;

            Console.WriteLine(multiplay(3, 5));
            Console.WriteLine(devide(3, 5));
            Console.WriteLine(add(3, 5));
        }
    }
}
