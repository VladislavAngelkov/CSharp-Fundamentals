using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double maxVolume = 0;
            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heght = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * heght;
                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
