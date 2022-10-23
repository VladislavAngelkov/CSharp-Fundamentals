using System;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] times = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            double leftPlayerTime = 0;
            double rightPlayerTime = 0;

            for (int i = 0; i < times.Length/2; i++)
            {
                if (times[i]==0)
                {
                    leftPlayerTime *= 0.8;
                }
                else
                {
                    leftPlayerTime += times[i];
                }
            }

            for (int i = times.Length-1; i > times.Length / 2; i--)
            {
                if (times[i] == 0)
                {
                    rightPlayerTime *= 0.8;
                }
                else
                {
                    rightPlayerTime += times[i];
                }
            }

            if (leftPlayerTime>rightPlayerTime)
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(rightPlayerTime, 2)}");
            }
            else if (rightPlayerTime>leftPlayerTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(leftPlayerTime, 2)}");
            }
        }
    }
}
