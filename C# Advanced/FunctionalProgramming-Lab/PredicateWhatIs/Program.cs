using System;
using System.Collections.Generic;

namespace PredicateWhatIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In the. NET Predicate<T> is Boolean method
            // Предикатът е - > Взема параметър Т и бръща булеан
            Predicate<int> isNegative = x => x < 0; // Проверяваме входа инт х дали е по малко от нула.

            Console.WriteLine(isNegative(5)); // false
            Console.WriteLine(isNegative(-5)); // true

            var nums = new List<int> {3, 5, -2, 10, 0 -3 };
            var negs = nums.FindAll(isNegative);
            Console.WriteLine(String.Join(", ", negs)); // -2, -3
        }
    }
}
