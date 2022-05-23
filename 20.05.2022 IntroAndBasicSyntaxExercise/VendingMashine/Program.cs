using System;
using System.Linq;
using System.Collections.Generic;

namespace VendingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double[] possibleCoins = new double[] { 0.1, 0.2, 0.5, 1, 2 };
            double avalilbleMoney = 0;
            while (input != "Start")
            {
                double coin = double.Parse(input);


                if (possibleCoins.Contains(coin))
                {
                    avalilbleMoney += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                input = Console.ReadLine();
            }
            Dictionary<string, double> products = new Dictionary<string, double>()
            {
                {"Nuts", 2.0 },
                {"Water", 0.7 },
                {"Crisps", 1.5 },
                {"Soda",  0.8},
                { "Coke", 1.0}
            };
            string product = Console.ReadLine();
            while (product != "End")
            {

                if (products.ContainsKey(product))
                {
                    if (products[product] <= avalilbleMoney)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        avalilbleMoney -= products[product];
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {avalilbleMoney:f2}");

        }
    }
}
//Nuts " with a price of 2.0
//•	"Water" with a price of 0.7
//•	"Crisps" with a price of 1.5
//•	"Soda" with a price of 0.8
//•	"Coke" with a price of 1.0

