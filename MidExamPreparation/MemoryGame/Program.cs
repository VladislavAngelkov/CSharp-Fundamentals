using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(' ');
            int moveCounter = 0;
            while (command[0] != "end")
            {
                moveCounter++;
                int firstIndex = int.Parse(command[0]);
                int secondIndex = int.Parse(command[1]);
                if (firstIndex==secondIndex || firstIndex<0 || firstIndex >=numbers.Count || secondIndex < 0 || secondIndex >= numbers.Count)
                {
                    numbers.Insert(numbers.Count / 2, $"-{moveCounter}a");
                    numbers.Insert(numbers.Count / 2, $"-{moveCounter}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (numbers[firstIndex] == numbers[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[firstIndex]}!");
                    numbers.RemoveAt(Math.Max(firstIndex, secondIndex));
                    numbers.RemoveAt(Math.Min(firstIndex, secondIndex));
                    if (numbers.Count==0)
                    {
                        Console.WriteLine($"You have won in {moveCounter} turns!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
