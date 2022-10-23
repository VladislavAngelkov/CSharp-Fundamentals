using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            
            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products = products.OrderBy(x => x).ToList();
            
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
