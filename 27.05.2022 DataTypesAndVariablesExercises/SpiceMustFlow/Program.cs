using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int storedSpice = 0;
            int days = 0;
            while (yield>=100)
            {
                days++;
                storedSpice += yield;
                yield -= 10;
                if (storedSpice>=26)
                {
                    storedSpice -= 26;
                }
                else
                {
                    storedSpice = 0;
                }
            }
            if (storedSpice >= 26)
            {
                storedSpice -= 26;
            }
            else
            {
                storedSpice = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(storedSpice);
        }
    }
}
