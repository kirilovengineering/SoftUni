using System;

namespace GenericDelegateMultiParametersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, int, int, long> example = (name, x, y, speed) => x * y * speed;
            // приема стринг инт, инт, инт и връща като резултат лонг, стринга не го връщаме тук
        }
    }
}
