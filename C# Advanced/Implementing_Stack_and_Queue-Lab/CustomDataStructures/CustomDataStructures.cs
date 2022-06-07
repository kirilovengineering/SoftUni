using System;

namespace CustomDataStructures
{
    internal class CustomDataStructures
    {
        static void Main(string[] args)
        {

            // Test Add Method
            var list = new CustomList<int>();

            list.Add(5);
            Console.WriteLine($"Adding element {list[0]}");
            list.Add(6);
            Console.WriteLine($"Adding element {list[1]}");
            list.Add(7);
            Console.WriteLine($"Adding element {list[2]}");
            list.Add(8);
            Console.WriteLine($"Adding element {list[3]}");
            Console.WriteLine($"List count are6 {list.Count}");
            Console.WriteLine($"-------------" + Environment.NewLine + "------------------");
            int removedElement = list.RemoveAt(2);
            Console.WriteLine($"removedElement {removedElement} at index 2");
            Console.WriteLine($"List count after removing element {list.Count}");

            Console.WriteLine($"-------------" + Environment.NewLine + "------------------");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Current element {list[i]}");
            }
            Console.WriteLine($"-------------" + Environment.NewLine + "------------------");
            // Test InsetAt Method
            var testInsert = new CustomList<int>();

            testInsert.Add(5);
            Console.WriteLine($"Adding element {testInsert[0]}");
            testInsert.Add(6);
            Console.WriteLine($"Adding element {testInsert[1]}");
            testInsert.Add(7);
            Console.WriteLine($"Adding element {testInsert[2]}");
            testInsert.Add(8);
            Console.WriteLine($"Adding element {testInsert[3]}");
            testInsert.InsertAt(1,23);

            Console.WriteLine($"Inserted elelment in index 1 is {testInsert[1]}");

            for (int i = 0; i < testInsert.Count; i++)
            {
                Console.WriteLine($"Current element {testInsert[i]}");
            };

            //......tests

            Console.WriteLine($"-------------" + Environment.NewLine + "------------------");

            var stack = new CustomStack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());
            int popedElement = stack.Pop();
            Console.WriteLine(popedElement);
            Console.WriteLine(stack.Count);

        }
    }
}
