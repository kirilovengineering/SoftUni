﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Revision")
                {
                    PrintPrices(prices);
                    break;
                }
                string[] parts = line.Split(", ");
                string shop = parts[0];
                string product = parts[1];
                double price = double.Parse(parts[2]);
                AddProduct(prices, shop, product, price);
            }
        }

        private static void AddProduct(Dictionary<string, Dictionary<string, double>> prices, string shop, string product, double price)
        {
            if (!prices.ContainsKey(shop))
                prices.Add(shop, new Dictionary<string, double>());
            prices[shop][product] = price;
        }

        private static void PrintPrices(Dictionary<string, Dictionary<string, double>> prices)
        {
            foreach (var shopAndProducts in prices.OrderBy(sp => sp.Key))
            {
                string shopName = shopAndProducts.Key;
                Console.WriteLine(shopName + "->");
                var products = shopAndProducts.Value;
                foreach (var iproductAndPrice in products)
                {
                    Console.WriteLine($"Product: {iproductAndPrice.Key}, Price: {iproductAndPrice.Value}");
                }
            }
        }
    }
}
