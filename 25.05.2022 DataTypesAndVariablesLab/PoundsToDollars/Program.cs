using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{(decimal.Parse(Console.ReadLine())*(decimal)1.31):f3}");
        }
    }
}
