﻿using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;

            switch (city)
            {
                case "Sofia":
                    //град / продукт coffee water beer sweets peanuts
                    //Sofia 0.50 0.80 1.20 1.45 1.60
                    switch (product)
                    {
                        case "coffee":
                            price = 0.50;
                            break;
                        case "water":
                            price = 0.80;
                            break;
                        case "beer":
                            price = 1.20;
                            break;
                        case "sweets":
                            price = 1.45;
                            break;
                        case "peanuts":
                            price = 1.60;
                            break;
                    }
                    break;

                case "Plovdiv":
                    //град / продукт coffee water beer sweets peanuts
                    //Plovdiv 0.40 0.70 1.15 1.30 1.50
                    switch (product)
                    {
                        case "coffee":
                            price = 0.40;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.15;
                            break;
                        case "sweets":
                            price = 1.30;
                            break;
                        case "peanuts":
                            price = 1.50;
                            break;
                    }
                    break;

                case "Varna":
                    //град / продукт coffee water beer sweets peanuts
                    //Varna 0.45 0.70 1.10 1.35 1.55
                    switch (product)
                    {
                        case "coffee":
                            price = 0.45;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.10;
                            break;
                        case "sweets":
                            price = 1.35;
                            break;
                        case "peanuts":
                            price = 1.55;
                            break;
                    }
                    break;
            }

            price *= quantity;
            Console.WriteLine(price);
        }
    }
}