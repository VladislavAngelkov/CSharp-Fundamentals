using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitPerWorker = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactoryBiscuits = int.Parse(Console.ReadLine());

            int totalBuiscuits = 0;

            int biscuitsPerDay = biscuitPerWorker * workers;

            for (int i = 1; i <= 30; i++)
            {
                if (i%3==0)
                {
                    totalBuiscuits += (int)Math.Floor(biscuitsPerDay * 0.75);
                }
                else
                {
                    totalBuiscuits += biscuitsPerDay;
                }
            }

            double percentDifference = (double)(Math.Abs(totalBuiscuits - competingFactoryBiscuits) * 100) / (double)competingFactoryBiscuits;

            Console.WriteLine($"You have produced {totalBuiscuits} biscuits for the past month.");

            if (totalBuiscuits>competingFactoryBiscuits)
            {
                Console.WriteLine($"You produce {percentDifference:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentDifference:f2} percent less biscuits.");
            }
        }
    }
}
