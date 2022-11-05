using System;
using System.Linq;

namespace ZHelp_Any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The following example returns true as the collection contains at least one element.
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var ResultMS = IntArray.Any();
            //Using Query Syntax
            var ResultQS = (from num in IntArray
                            select num).Any();
            Console.WriteLine("Is there any element in the collection : " + ResultMS);
            Console.ReadKey();
            //Output - Is there any element in the collection : True

            //The following program returns false as there is no element that is less than 10.
            int[] IntArray10 = { 11, 22, 33, 44, 55 };
            var Result = IntArray10.All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result);
            Console.ReadKey();
            //Output - Is All Numbers are greater than 10 : True

            //The following example returns true as some of the names are greater than 5 characters.
            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Method Syntax
            var ResultMS5 = stringArray.Any(name => name.Length > 5);
            //Query Syntax
            var ResultQS5 = (from name in stringArray
                            select name).Any(name => name.Length > 5);
            Console.WriteLine("Is Any name with length  greater than 5 Characters : " + ResultMS5);
            Console.ReadKey();
            //Output - Is Any name with length  greater than 5 Characters : False

        }
    }
}
