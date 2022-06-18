using System;
using System.Collections.Generic;
using System.Linq;

namespace ZHelp_nameof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A nameof expression produces the name of a variable, type, or member as the string constant:
            Console.WriteLine(nameof(System.Collections.Generic));  // output: Generic
            Console.WriteLine(nameof(List<int>));  // output: List
            Console.WriteLine(nameof(List<int>.Count));  // output: Count
            Console.WriteLine(nameof(List<int>.Add));  // output: Add

            var numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine(nameof(numbers));  // output: numbers
            Console.WriteLine(nameof(numbers.Count));  // output: Count
            Console.WriteLine(nameof(numbers.Add));  // output: Add

            //In the case of verbatim identifiers, the @ character is not the part of a name, as the following example shows:

            var @new = 5;
            Console.WriteLine(nameof(@new));  // output: new

            //
            var temp1 = nameof(numbers);
            var temp2 = numbers;
            Console.WriteLine(temp1); // output: numbers
            Console.WriteLine(temp2); // output System.Collections.Generic.List`1[System.Int32]

            //You can use a nameof expression to make the argument-checking code more maintainable:

            //    public string Name
            //{
            //    get => name;
            //    set => name = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Name)} cannot be null");
            //}

            //The argument to the nameof operator must be in scope.Beginning with C# 11, parameters and type parameters are in scope inside an attribute for the purpose of the nameof operator. The following examples show nameof used on parameters for a method, a local function, and a lambda expression:

            //[ParameterString(nameof(msg))]
            //public static void Method(string msg)
            //{
            //    [ParameterString(nameof(param))]
            //    void LocalFunction(string param)
            //    { }

            //    var lambdaExpression = [ParameterString(nameof(aNumber))] (int aNumber) => aNumber.ToString();

            //}
        }
    }
}
