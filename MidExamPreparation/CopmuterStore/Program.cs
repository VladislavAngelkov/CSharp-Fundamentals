using System;

namespace CopmuterStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal priceWithoutTaxes = 0;
            while (command != "special" && command != "regular")
            {
                decimal currentPartPrice = decimal.Parse(command);
                if (currentPartPrice<0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTaxes += currentPartPrice;
                }
                
                command = Console.ReadLine();
            }
            if (priceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                decimal finalPrice = 0;
                decimal taxes = 0;
                taxes = priceWithoutTaxes * (decimal)0.2;
                
                finalPrice = priceWithoutTaxes + taxes;
                
                if (command == "special")
                {
                   finalPrice*=(decimal)0.9;
                }

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
        }
    }
}
