using System;
using System.IO;

namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  в случая ще отпечата ексепшън защото няма да намери input.txt

            StreamReader reader = null;
            int linesCount = 0;
            try // опитваме да прочетем файл, ако прочетем обработваме
            {
                reader = new StreamReader("input.txt");
                while (reader.ReadLine() != null)
                    linesCount++;
                Console.WriteLine("Lines count: {0}", linesCount);
            }
            catch (Exception ex) // ако не успеем хващаме грешка и отпечатваме .. грешка
            {
                Console.Error.WriteLine("Error reading file: {0}", ex);
            }
            finally
            {
                if (reader != null) reader.Close(); // накрая задължително затваряме стриима
            }

        }
    }
}
