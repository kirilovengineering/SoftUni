using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


            Func<List<int>, List<int>> add = list => list.Select(number => number += 1).ToList();
            Func<List<int>, List<int>> multiplay = list => list.Select(number => number *= 2).ToList();
            Func<List<int>, List<int>> substract = list => list.Select(number => number -= 1).ToList();
            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        //получваме списък и връщаме модифициран списък като всеки елемент е увеличен с 1
                        numbers = add(numbers);
                        break;
                    case "multiply":
                        //получваме списък и връщаме модифициран списък като всеки елемент е умножен с 2
                        numbers = multiplay(numbers);
                        break;
                    case "subtract":
                        //получваме списък и връщаме модифициран списък като всеки елемент е намален с 1
                        numbers = substract(numbers);
                        break;
                    case "print":
                        //получваме списък и го принтираме
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
