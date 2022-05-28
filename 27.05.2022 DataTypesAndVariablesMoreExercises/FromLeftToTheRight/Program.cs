using System;
using System.Linq;
using System.Numerics;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
                BigInteger biggerNumber = int.MinValue;
                if (numbers[0]>numbers[1])
                {
                    biggerNumber = numbers[0];
                }
                else
                {
                    biggerNumber = numbers[1];
                }
                int lastDigit = 0;
                BigInteger currentNumber = biggerNumber;
                int digitSum = 0;
                while (currentNumber != 0)
                {
                    lastDigit = (int)(currentNumber % 10);
                    currentNumber /= 10;
                    digitSum += lastDigit;
                }
                Console.WriteLine(Math.Abs(digitSum));
            }
        }
    }
}
