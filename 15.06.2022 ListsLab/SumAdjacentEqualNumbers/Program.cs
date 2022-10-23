using System;
using System.Linq;
using System.Collections.Generic;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            bool adjacentEquals = true;
            while (adjacentEquals)
            {
                adjacentEquals = false;
                for (int i = 0; i < numbers.Count-1; i++)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        numbers[i] += numbers[i];
                        numbers.RemoveAt(i + 1);
                        adjacentEquals = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
