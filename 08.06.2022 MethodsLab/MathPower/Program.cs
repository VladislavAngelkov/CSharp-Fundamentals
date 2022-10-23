using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToThePower(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        public static double ToThePower(double baseNumber, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
