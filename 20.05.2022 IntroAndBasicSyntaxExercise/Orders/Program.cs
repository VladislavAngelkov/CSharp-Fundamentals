using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double coffePrice = 0;
            double totalPrice = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                double priceOfCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                coffePrice = (days * capsuleCount) * priceOfCapsule;
                totalPrice += coffePrice;
                Console.WriteLine($"The price for the coffee is: ${coffePrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
