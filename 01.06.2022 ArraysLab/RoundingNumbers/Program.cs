using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == -0)
                {
                    Console.WriteLine($"{numbers[i]} => {Math.Abs(Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero))}");
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero)}");
                }
            }
        }
    }
}
