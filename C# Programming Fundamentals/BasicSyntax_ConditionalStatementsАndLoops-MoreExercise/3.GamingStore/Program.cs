using System;

namespace _3.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine()), total = 0;
            string command = Console.ReadLine();

            while (command != "Game Time")
            {

                if (balance == 0)
                    break;

                switch (command)
                {
                    case "OutFall 4":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 39.99;
                            total += 39.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        break;
                    case "CS: OG":

                        if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 15.99;
                            total += 15.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        break;
                    case "Zplinter Zell":

                        if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 19.99;
                            total += 19.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        break;
                    case "Honored 2":
                        if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 59.99;
                            total += 59.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        break;
                    case "RoverWatch":
                        if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 29.99;
                            total += 29.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            balance -= 39.99;
                            total += 39.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                command = Console.ReadLine();
            }
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
