using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaterPouring = int.Parse(Console.ReadLine());
            int LeftVolumeInTheTank = 255;
            for (int i = 0; i < numberOfWaterPouring; i++)
            {
                int waterIntake = int.Parse(Console.ReadLine());
                if (waterIntake>LeftVolumeInTheTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    LeftVolumeInTheTank -= waterIntake;
                }
            }
            Console.WriteLine($"{255-LeftVolumeInTheTank}");
        }
    }
}
