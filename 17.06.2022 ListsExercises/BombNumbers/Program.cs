using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bombnumber = bomb[0];
            int power = bomb[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombnumber)
                {
                    for (int j = 0; j < power; j++)
                    {
                        if (i+1<numbers.Count)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                    }
                    for (int j = 0; j < power; j++)
                    {
                        if (i-1>=0)
                        {
                            numbers.RemoveAt(i - 1);
                            i -= 1;
                        }
                    }
                    numbers.RemoveAt(i);
                    i -= 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
