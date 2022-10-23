using System;
using System.Linq;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                string[] weekDays = new string[7]{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
                Console.WriteLine($"{weekDays[day - 1]}");
            }
        }
    }
}
