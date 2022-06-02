using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ").ToList();
            string command = Console.ReadLine();

            while (command != "Party!")
            {
                //командит може да са "Double ..." или "Remove ..."
                if (command.StartsWith("Double"))
                {
                    //дублиране
                }
                else if (command.StartsWith("Remove"))
                {
                    //премахване
                }

                command = Console.ReadLine();
            }
        }
    }
}
