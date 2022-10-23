using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> initialDrumQuality = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> currentDrumQuality = new List<int>();

            foreach (var drum in initialDrumQuality)
            {
                currentDrumQuality.Add(drum);
            }

            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int hitStrength = int.Parse(command);

                for (int i = 0; i < currentDrumQuality.Count; i++)
                {
                    if (hitStrength<=currentDrumQuality[i])
                    {
                        currentDrumQuality[i] -= hitStrength;
                    }
                    else
                    {
                        currentDrumQuality[i] = 0;
                    }

                    if (currentDrumQuality[i] == 0 && initialDrumQuality[i]*3<=savings)
                    {
                        currentDrumQuality[i] = initialDrumQuality[i];
                        savings -= initialDrumQuality[i]*3;
                    }
                }

                command = Console.ReadLine();
            }

            currentDrumQuality = currentDrumQuality.Where(x => x != 0).ToList();

            Console.WriteLine(string.Join(" ", currentDrumQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
