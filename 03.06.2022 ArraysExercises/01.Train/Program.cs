using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[numberOfWagons];
            int sumOfPassangers = 0;
            for (int i = 0; i < numberOfWagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sumOfPassangers += passengers[i];
            }
            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(sumOfPassangers);
        }
    }
}
