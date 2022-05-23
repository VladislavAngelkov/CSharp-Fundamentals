using System;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 0;
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
           
            if (age>=0 && age<=18)
            {
                if (day == "Weekday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "Weekend")
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "Holiday")
                {
                    price = 5;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (age>18 && age <=64)
            {
                if (day == "Weekday")
                {
                    price = 18;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "Weekend")
                {
                    price = 20;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "Holiday")
                {
                    price = 22;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (age>64 && age<=122)
            {
                if (day == "Weekday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "Weekend")
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "Holiday")
                {
                    price = 10;
                    Console.WriteLine($"{price}$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            } 
        }
    }
}
