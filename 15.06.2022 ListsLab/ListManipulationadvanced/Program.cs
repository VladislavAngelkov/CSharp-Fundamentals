using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationadvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            bool isChanged = false;
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1]))? "Yes": "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(x=>x%2==0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":

                        if (command[1] == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x=>x<int.Parse(command[2]))));
                        }
                        else if (command[1] == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > int.Parse(command[2]))));
                        }
                        else if (command[1] == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= int.Parse(command[2]))));
                        }
                        else if (command[1] == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= int.Parse(command[2]))));
                        }

                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
