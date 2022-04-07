using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{

    class Item
    { 
        public string Name { get; set; }    

        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox
        {
            get
            {
                return this.Quantity * this.Item.Price;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string entered = Console.ReadLine();

            while (entered != "end")
            {
                string[] tokens = entered.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = tokens[0];
                string name = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = name,
                        Price = price
                    },
                    Quantity = quantity,
                };

                boxes.Add(box);

                entered = Console.ReadLine();
            }
                List<Box> orderedBoxes = boxes
                        .OrderByDescending(exampleB => exampleB.PriceBox)
                        .ToList();

                foreach (Box currBox in orderedBoxes)
                {
                    Console.WriteLine($"{currBox.SerialNumber}");
                    Console.WriteLine($"-- {currBox.Item.Name} - ${currBox.Item.Price:f2}: {currBox.Quantity}");
                    Console.WriteLine($"-- ${currBox.PriceBox:f2}");
                }
        }
    }
}
