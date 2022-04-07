using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quatity = int.Parse(Console.ReadLine());

                //if (resources.ContainsKey(resource))
                //{
                //    resources[resource] += quatity;
                //}
                //else
                //{
                //    resources.Add(resource, quatity);
                //}

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quatity;

            }

            foreach (var item in resources)
            {
                string currentResource = item.Key;
                long resourcesQantity = item.Value;

                Console.WriteLine($"{currentResource} -> {resourcesQantity}");
            }
        }
    }
}
