using System;
using System.Collections.Generic;
using System.Text;

namespace TestDoublyLinkedList
{
    internal class Program
    {
        public static void Main()
        {
            // Всичко в това в тази имплементация е възможно с LinkedList вграден клас:
            LinkedList<int> primerenLinkedList = new LinkedList<int>();
            // Имплементацията в TestDoublyLinkedList.cs с цел демонстрация на LinkedList как са го
            // написали Майкрософт

            var linkedList = new DoublyLinkedList<int>();

            linkedList.AddHead(1);
            linkedList.AddHead(2);
            linkedList.AddHead(3);
            linkedList.AddTail(4);
            linkedList.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("--------------" + Environment.NewLine + "---------------");

            var array = linkedList.ToArray();

            Console.WriteLine($"Head : {linkedList.Head.Value}");
            Console.WriteLine($"Head : {linkedList.Tail.Value}");

            Console.WriteLine($"Next to Head : {linkedList.Head.Next.Value}");
            Console.WriteLine($"Previous to Head : {linkedList.Tail.Previous.Value}");

            Console.WriteLine("--------------" + Environment.NewLine + "---------------");

            var horo = new DoublyLinkedList<string>();

            horo.AddHead("Lili");
            horo.AddHead("Ivan");
            horo.AddHead("Andrei");
            horo.AddTail("Gergana");

            // Нека да принтираме линкед листа

            horo.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("--------------" + Environment.NewLine + "---------------");
            // На конзолата се рапечатва
            // Andrei
            // Ivan
            // Lili
            // Gergana

            // бърз индексатор не може да се направи в линкд лист, концепцията не е такава ...
            // Ако се сложи индексатор то става List
            // може да се добави елемент така:

            horo.Head.Next.Next.Next = new DoublyLinkedList<string>.LinkedListNode("Last People");
            horo.ForEach(p => Console.WriteLine(p));


            // с по долния код се добавя на второ място след хеад това което искаме но другото се затрива

            Console.WriteLine("--------------" + Environment.NewLine + "---------------");

            horo.Head.Next = new DoublyLinkedList<string>.LinkedListNode("Last People");
            horo.ForEach(p => Console.WriteLine(p));
        }
    }
}
