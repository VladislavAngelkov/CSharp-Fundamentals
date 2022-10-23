using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Dictionary<int, int> numberOcurrences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numberOcurrences.ContainsKey(numbers[i]))
                {
                    numberOcurrences.Add(numbers[i], 0);
                }

                numberOcurrences[numbers[i]]++;
            }

            foreach (var number in numberOcurrences.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
