using System;

namespace _5Task_CSharp_Exam14112021
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string numberGoals = Console.ReadLine();

            string BestPlayer = "";
            int goals = 0;
            

            while (name != "END")
            {
                if (int.Parse(numberGoals) >= 10)
                {
                    BestPlayer = name;
                    goals = int.Parse(numberGoals);
                    break;
                }
                if (int.Parse(numberGoals) > goals)
                {
                    goals = int.Parse(numberGoals);
                    BestPlayer = name;
                }
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                numberGoals = Console.ReadLine();             
            }
            Console.WriteLine($"{BestPlayer} is the best player!");
            if (goals >= 3)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}
