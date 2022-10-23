using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            int currentIndex = 0;
            while (command[0] != "Love!")
            {
                int lenght = int.Parse(command[1]);
                currentIndex += lenght;
                if (currentIndex>=neighborhood.Length)
                {
                    currentIndex = 0;
                }
                if (neighborhood[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                    neighborhood[currentIndex] -= 2;
                    if (neighborhood[currentIndex]==0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }

                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            int failedHouses = 0;
            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i]!=0)
                {
                    failedHouses++;
                }
            }
            if (failedHouses>0)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
