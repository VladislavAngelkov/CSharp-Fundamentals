using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitinigPeople = int.Parse(Console.ReadLine());
            int[] liftWagons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool liftIsFull = false;

            while (waitinigPeople>0 && !liftIsFull)
            {
                for (int i = 0; i < liftWagons.Length; i++)
                {
                    if (liftWagons[i] < 4)
                    {
                        int freeSpots = 4 - liftWagons[i];
                        if (waitinigPeople<=freeSpots)
                        {
                            liftWagons[i] += waitinigPeople;
                            waitinigPeople = 0;
                            break;
                        }
                        else
                        {
                            liftWagons[i] = 4;
                            waitinigPeople -= freeSpots;
                        }
                    }
                }
                liftIsFull = true;
                for (int i = 0; i < liftWagons.Length; i++)
                {
                    if (liftWagons[i]!=4)
                    {
                        liftIsFull = false;
                       
                    }
                }
            }
            if (waitinigPeople==0 && liftIsFull)
            {
                Console.WriteLine(string.Join(" ", liftWagons));
            }
            else if (waitinigPeople == 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", liftWagons));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {waitinigPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", liftWagons));
            }
        }
    }
}
