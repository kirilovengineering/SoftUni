using System;

namespace ActionWhatIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // функция, която не връща нищо
            void Print(string s)
            {
                Console.WriteLine(s);
            }

            // Когато нещо в C# не връща стойност това е Екшън
            Action<string> print = Print;

            //после екшъна може да се извиква с параметър "Петър", или без параметър

            print("Petar");
            print(5.ToString());

            // Mоже да е и с ламда експрешън
            Action<string> printLambda =
                message => Console.WriteLine(message);

            printLambda("This is lambda message");
            printLambda(5.ToString());


        }
    }
}
