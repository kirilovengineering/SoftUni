using System;

namespace _03.GenericScale
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> cupleInt = new EqualityScale<int>(1, 1);

            bool eqInt = cupleInt.AreEqual();
            Console.WriteLine(eqInt);
            // Връща true при сравнениен на двете инт съойности


            EqualityScale<String> cupleString = new EqualityScale<String>("Kiril", "NotKiril");

            bool eqString = cupleString.AreEqual();
            Console.WriteLine(eqString);
            // Връща false при сравнение на двата стринга

        }
    }
}
