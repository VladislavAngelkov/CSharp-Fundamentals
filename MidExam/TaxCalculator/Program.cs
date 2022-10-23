using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine().Split(">>");
            int totalTaxes = 0;

            for (int i = 0; i < cars.Length; i++)
            {
                string[] car = cars[i].Split(" ");
                string carType = car[0];
                int years = int.Parse(car[1]);
                int kilometers = int.Parse(car[2]);
                int taxPerCar = 0;

                if (carType == "family")
                {
                    int initialTax = 50;
                    int yearDiscount = years * 5;
                    int distanceTax = (kilometers / 3000) * 12;
                    taxPerCar = initialTax + distanceTax - yearDiscount;
                }
                else if (carType == "heavyDuty")
                {
                    int initialTax = 80;
                    int yearDiscount = years * 8;
                    int distanceTax = (kilometers / 9000) * 14;
                    taxPerCar = initialTax + distanceTax - yearDiscount;
                }
                else if (carType == "sports")
                {
                    int initialTax = 100;
                    int yearDiscount = years * 9;
                    int distanceTax = (kilometers / 2000) * 18;
                    taxPerCar = initialTax + distanceTax - yearDiscount;
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                    continue;
                }

                totalTaxes += taxPerCar;
                Console.WriteLine($"A {carType} car will pay {taxPerCar:f2} euros in taxes.");
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTaxes:f2} euros in taxes.");
        }
    }
}
