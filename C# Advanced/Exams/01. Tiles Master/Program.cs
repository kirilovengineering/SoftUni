using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] white = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackWhite = new Stack<int>(white);
            int[] gray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queueGray = new Queue<int>(gray);

            int sum = 0;
            // Трябва да съхраняваме метсата на монтаж от вид
            // Запис място -> брой
            Dictionary<string, int> place = new Dictionary<string, int>
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0 },
                {"Wall", 0 },
                {"Floor", 0 },
            };

            int totalPlaces = 0; // За отпечатването ни трябва общия брой монтирани места
            while (stackWhite.Count > 0 && queueGray.Count > 0)
            {
                int currentWhite = stackWhite.Peek();
                int currentGrey = queueGray.Peek();
                if (currentWhite == currentGrey)
                {
                    sum = currentWhite + currentGrey;
                }


                if (sum == 40)
                {
                    //Монтираме Sink
                    place["Sink"]++;
                    totalPlaces++;
                    stackWhite.Pop(); // премахваме първият елемент от опашката
                    queueGray.Dequeue(); // премахваме най горния елемент от стека
                }
                else if (sum == 50)
                {
                    //Монтираме Oven
                    place["Oven"]++;
                    totalPlaces++;
                    stackWhite.Pop(); // премахваме първият елемент от опашката
                    queueGray.Dequeue(); // премахваме най горния елемент от стека
                }
                else if (sum == 60)
                {
                    //Монтираме Countertop
                    place["Countertop"]++;
                    totalPlaces++;
                    stackWhite.Pop(); // премахваме първият елемент от опашката
                    queueGray.Dequeue(); // премахваме най горния елемент от стека
                }
                else if (sum == 70)
                {
                    //Монтираме Wall
                    place["Wall"]++;
                    totalPlaces++;
                    stackWhite.Pop(); // премахваме първият елемент от опашката
                    queueGray.Dequeue(); // премахваме най горния елемент от стека
                }
                else if(currentWhite == currentGrey)
                {
                    place["Floor"]++;
                    stackWhite.Pop();
                    queueGray.Dequeue();
                }
                else
                {
                    //Ако не монтираме
                    if (currentWhite != currentGrey)
                    {
                        currentWhite = currentWhite / 2;
                        stackWhite.Pop();
                        stackWhite.Push(currentWhite);
                        queueGray.Dequeue();
                        queueGray.Enqueue(currentGrey);
                    }
                }


            }

            if (stackWhite.Count == 0)
            {
                Console.WriteLine($"White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: " + String.Join(", ", stackWhite));
            }

            if (queueGray.Count == 0)
            {
                Console.WriteLine($"Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: " + String.Join(", ", queueGray));
            }



            //var sortedDict = from entry in place orderby entry.Value ascending select entry;
            //var ordered = place.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            //var orderedd = sortedDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //    SortedDictionary<string, int> sortedPlace = new SortedDictionary<string, int>(place);
            ////foreach (var keyValuePair in sortedPlace)
            //// ако не го сортираме преди това може->

            foreach (var location in place.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }

        }

    }
}
