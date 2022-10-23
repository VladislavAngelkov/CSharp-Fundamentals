using System;
using System.Collections.Generic;

namespace Orders
{
    class Product
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> orders = new Dictionary<string, Product>();

            string[] order = Console.ReadLine().Split(" ");

            while (order[0] != "buy")
            {
                string productName = order[0];
                double price = double.Parse(order[1]);
                int quantity = int.Parse(order[2]);

                if (!orders.ContainsKey(productName))
                {
                    Product product = new Product();
                    orders.Add(productName, product);
                }

                orders[productName].Price = price;
                orders[productName].Quantity += quantity;

                order = Console.ReadLine().Split(" ");
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price*item.Value.Quantity:f2}");
            }
        }
    }
}
