using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerMan = 0;
            int discount = 0;
            switch (day)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":
                            pricePerMan = 8.45;
                            break;
                        case "Business":
                            pricePerMan = 10.90;
                            break;
                        case "Regular":
                            pricePerMan = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students":
                            pricePerMan = 9.80;
                            break;
                        case "Business":
                            pricePerMan = 15.60;
                            break;
                        case "Regular":
                            pricePerMan = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students":
                            pricePerMan = 10.46;
                            break;
                        case "Business":
                            pricePerMan = 16;
                            break;
                        case "Regular":
                            pricePerMan = 22.50;
                            break;
                    }
                    break;
            }
            if (type == "Students" && count >=30)
            {
                discount = 15;
            }
            else if (type == "Business" && count>=100)
            {
                count -= 10;
            }
            else if (type == "Regular" && count >=10 && count <=20)
            {
                discount = 5;
            }
            double totalPrice = count * pricePerMan * ((double)(100 - discount) / (double)100);
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
