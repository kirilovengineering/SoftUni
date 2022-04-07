using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> productInfo = new Dictionary<string, List<decimal>>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] productArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string productName = productArgs[0];
                decimal productPrice = decimal.Parse(productArgs[1]);
                decimal productQuntity = decimal.Parse(productArgs[2]);

                if (!productInfo.ContainsKey(productName))
                {

                    productInfo[productName] = new List<decimal>();
                    productInfo[productName].Add(productPrice);
                    productInfo[productName].Add(productQuntity);
                }
                else
                {
                    foreach (var KeyValuePear in productInfo)
                    {
                        string productNameTemp = KeyValuePear.Key;
                        if (productNameTemp == productName)
                        {
                            List<decimal> Temp = new List<decimal>();
                            Temp = KeyValuePear.Value;

                            decimal tempQuntity = Temp[1];

                            tempQuntity = tempQuntity + productQuntity;

                            productInfo[productNameTemp].Clear();
                            productInfo[productNameTemp].Add(productPrice);
                            productInfo[productNameTemp].Add(tempQuntity);
                        }
                    }
                }
            }
            PrintProductInfo(productInfo);
        }

        static void PrintProductInfo(Dictionary<string, List<decimal>> productInfo)
        {
            foreach (var kvp in productInfo)
            {
                string productName = kvp.Key;
                List<decimal> productsPriseAndQuantity = kvp.Value;

                decimal totalPrice = productsPriseAndQuantity[0] * productsPriseAndQuantity[1];
                

                Console.WriteLine($"{productName} -> {totalPrice:F2}");

            }
        }
    }

}
