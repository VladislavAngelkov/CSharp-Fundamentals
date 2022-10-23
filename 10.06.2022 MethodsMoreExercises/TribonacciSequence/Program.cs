using System;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Tribonacci(int.Parse(Console.ReadLine()))));
        }

        static int[] Tribonacci(int numbersCount)
        {
            int[] tribonacciSequence = new int[numbersCount];
            int firstPrevious = 0;
            int secondPrevious = 0;
            int thirdPrevious = 0;
            tribonacciSequence[0] = 1;
            for (int i = 1; i < numbersCount; i++)
            {
                firstPrevious = tribonacciSequence[i - 1];
                if (i > 1)
                {
                    secondPrevious = tribonacciSequence[i - 2];
                }
                if (i > 2)
                {
                    thirdPrevious = tribonacciSequence[i - 3];
                }
                tribonacciSequence[i] = firstPrevious + secondPrevious + thirdPrevious;
            }
            return tribonacciSequence;
        }
    }
}
