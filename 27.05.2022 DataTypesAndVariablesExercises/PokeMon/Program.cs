using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int numberOfPokes = 0;
            int currentPokePower = initialPokePower;
            while (currentPokePower >= distance)
            {
                numberOfPokes++;
                currentPokePower -= distance;
                if (currentPokePower == initialPokePower*0.5 && exhaustionFactor!=0)
                {

                    currentPokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(numberOfPokes);
        }
    }
}
