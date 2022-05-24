using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{(decimal.Parse(Console.ReadLine())/(decimal)1000):f2}");
        }
    }
}
