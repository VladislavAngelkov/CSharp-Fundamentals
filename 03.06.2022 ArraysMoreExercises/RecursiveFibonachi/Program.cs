using System;

namespace RecursiveFibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonachiNumber = int.Parse(Console.ReadLine());
            int[] numbers = new int[50];
            numbers[0] = 1;
            numbers[1] = 1;
            if (fibonachiNumber == 1 || fibonachiNumber == 2)
            {
                Console.WriteLine(1);
                return;
            }
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
                if (i+1==fibonachiNumber)
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }
            }
        }
    }
}
