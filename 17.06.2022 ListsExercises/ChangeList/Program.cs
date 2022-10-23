using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    numbers = numbers.Where(x => x != int.Parse(command[1])).ToList();
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
