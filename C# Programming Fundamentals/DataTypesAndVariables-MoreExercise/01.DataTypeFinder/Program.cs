using System;

namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType = "";
            int flagInteger = 0;
            int flagFloatingPoint = 0;
            int flagCharacters = 0;
            int flagStrings = 0;
            int flagBoolean = 0;

               
            while (input != "END")
            {

                flagInteger = 0;
                flagFloatingPoint = 0;
                flagCharacters = 0;
                flagStrings = 0;
                flagBoolean = 0;

                int numberInt;
                bool successInt = int.TryParse(input, out numberInt);
                if (successInt)
                {
                    flagInteger = 1;
                }

                float numberFloat;
                bool successFloat = float.TryParse(input, out numberFloat);
                if (successFloat)
                {
                    flagFloatingPoint = 1;
                }

                if (input.Length == 1 && (successInt == false || successFloat == false))
                {
                    flagCharacters = 1;
                }
                
                if (input.Length > 1 && (successInt == false && successFloat == false))
                {
                    flagStrings = 1;
                }

                if (input == "true" || input == "false")
                {
                    flagBoolean = 1;
                }
                //-------------------------------------------------------------
                if (flagInteger == 1 && flagFloatingPoint == 1 && flagCharacters == 0 && flagStrings == 0 && flagBoolean == 0)
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                if (flagInteger == 0 && flagFloatingPoint == 1 && flagCharacters == 0 && flagStrings == 0 && flagBoolean == 0 && input.Length > 1)
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                if (flagInteger == 0 && flagFloatingPoint == 0 && flagCharacters == 1 && flagStrings == 0 && flagBoolean == 0)
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                if (flagInteger == 0 && flagFloatingPoint == 0 && flagCharacters == 0 && flagStrings == 1 && flagBoolean == 0)
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                if (flagInteger == 0 && flagFloatingPoint == 0 && flagCharacters == 0 && flagStrings == 1 && flagBoolean == 1)
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
