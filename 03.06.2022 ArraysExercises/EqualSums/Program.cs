using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool existEqualDivider = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                int rightSum = 0;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum==rightSum)
                {
                    existEqualDivider = true;
                    Console.WriteLine(i);
                }
            }
            if (!existEqualDivider)
            {
                Console.WriteLine("no");
            }
        }
    }
}
