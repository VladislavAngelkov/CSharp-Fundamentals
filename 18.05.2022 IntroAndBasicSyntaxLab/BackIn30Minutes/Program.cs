using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalminutes = hours * 60 + minutes + 30;
            int hoursToCome = totalminutes / 60;
            int minutesToCome = totalminutes % 60;
            if (hoursToCome>=24)
            {
                hoursToCome = 0;
            }
            Console.WriteLine($"{hoursToCome}:{minutesToCome:d2}");
        }

    }
}
