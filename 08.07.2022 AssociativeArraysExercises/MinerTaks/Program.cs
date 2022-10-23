using System;
using System.Collections.Generic;

namespace MinerTaks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                if (!resourses.ContainsKey(resource))
                {
                    resourses.Add(resource, 0);
                }

                resourses[resource] += int.Parse(Console.ReadLine());

                resource = Console.ReadLine();
            }

            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
