using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());

            Dictionary<string, int> plantsAndRarity = new Dictionary<string, int>();

            for (int i = 0; i < numberOfPlants; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");
                string name = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (!plantsAndRarity.ContainsKey(name))
                {
                    plantsAndRarity.Add(name, 0);
                }

                plantsAndRarity[name] = rarity;
            }

            Dictionary<string, List<int>> ratings = new Dictionary<string, List<int>>();

            foreach (var plant in plantsAndRarity)
            {
                ratings.Add(plant.Key, new List<int>());
            }

            string[] command = Console.ReadLine().Split(": ");

            while (command[0] != "Exhibition")
            {
                string cmd = command[0];
                string[] arguments = command[1].Split(" - ");

                switch (cmd)
                {
                    case "Rate":
                        string plantForRateing = arguments[0];
                        int rating = int.Parse(arguments[1]);
                        
                        if (ratings.ContainsKey(plantForRateing))
                        {
                            ratings[plantForRateing].Add(rating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "Update":
                        string plantForUdate = arguments[0];
                        int newRarity = int.Parse(arguments[1]);

                        if (plantsAndRarity.ContainsKey(plantForUdate))
                        {
                            plantsAndRarity[plantForUdate] = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "Reset":
                        string plantForReset = arguments[0];
                        if (ratings.ContainsKey(plantForReset))
                        {
                            ratings[plantForReset] = new List<int>();
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                       
                        break;
                }

                command = Console.ReadLine().Split(": ");
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantsAndRarity)
            {
                if (ratings[plant.Key].Count == 0)
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: 0.00");
                }
                else
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {ratings[plant.Key].Average():f2}");
                }
            }
        }
    }
}
