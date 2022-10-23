using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestIneger(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        public static int SmallestIneger(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallest = 0;
            if (firstNumber<secondNumber)
            {
                smallest = firstNumber;
            }
            else
            {
                smallest = secondNumber;
            }
            if (thirdNumber<smallest)
            {
                smallest = thirdNumber;
            }
            return smallest;
        }
    }
}
