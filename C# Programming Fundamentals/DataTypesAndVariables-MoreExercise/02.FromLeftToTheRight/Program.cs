using System;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nRows = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            string left = String.Empty;
            string right = String.Empty;
            double numLeft = 0;
            double numRight = 0;    

            for (int i = 0; i < nRows; i++)
            {
                string input = Console.ReadLine();
                int lenghtString = input.Length;
                int index = input.IndexOf(" ");


                for (int j = 0; j < index; j++)
                {
                    char temp = input[j];
                    int number = (int)temp - 48;
                    sumLeft += number;
                    left += temp;
                    numLeft = double.Parse(left);

                }


                for (int k = index + 1; k < lenghtString; k++)
                {
                    char temp = input[k];
                    int number = (int)temp - 48;
                    sumRight += number;
                    right += temp;
                    numRight = double.Parse(right);
                }

                if (numLeft > numRight)
                {
                Console.WriteLine(sumLeft);
                }
                else
                {
                Console.WriteLine(sumRight);
                }
                sumLeft = 0;
                sumRight = 0;

            }

        }
    }
}
