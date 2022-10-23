using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintingTiangle(int.Parse(Console.ReadLine()));
        }
        public static void PrintingTiangle(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write($"{j+1} ");
                }
                Console.WriteLine();
            }
            for (int i = number-1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{j + 1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
