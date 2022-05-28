using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());
            int bestSnowAmount = 0;
            int bestTime = 0;
            int bestQuality = 0;
            BigInteger bestValue = 0;
            for (int i = 0; i < snowballsCount; i++)
            {
                int snowAmount = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = (snowAmount / time);
                value = BigInteger.Pow(value, quality);
                if (value>bestValue)
                {
                    bestValue = value;
                    bestSnowAmount = snowAmount;
                    bestTime = time;
                    bestQuality = quality;
                }
            }
            Console.WriteLine($"{bestSnowAmount} : {bestTime} = {bestValue} ({bestQuality})");
           
        }
    }
}

