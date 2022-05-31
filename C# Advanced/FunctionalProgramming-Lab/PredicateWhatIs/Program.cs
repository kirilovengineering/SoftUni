using System;

namespace PredicateWhatIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Предикатът е - > Взема параметър Т и бръща булеан
            Predicate<int> isNegative = x => x < 0; // Проверяваме входа инт х дали е по малко от нула.
        }
    }
}
