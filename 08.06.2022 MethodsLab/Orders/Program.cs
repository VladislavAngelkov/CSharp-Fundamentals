using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderPrice(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        public static void OrderPrice(string product, int quantity)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = quantity * 1.50;
            }
            else if (product == "water")
            {
                price = quantity * 1.00;
            }
            else if (product == "coke")
            {
                price = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                price = quantity * 2.00;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
