using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();
            string[] command = Console.ReadLine().Split(" ");
            while (command[0] != "Go")
            {
                if (command[0] == "Urgent" && !groceries.Contains(command[1]))
                {
                    groceries.Insert(0, command[1]);
                }
                else if (command[0] == "Unnecessary" && groceries.Contains(command[1]))
                {
                    groceries.Remove(command[1]);
                }
                else if (command[0] == "Correct" && groceries.Contains(command[1]))
                {
                    string oldItem = command[1];
                    string newItem = command[2];
                    groceries[groceries.IndexOf(oldItem)] = newItem;
                }
                else if (command[0] == "Rearrange" && groceries.Contains(command[1]))
                {
                    string item = command[1];
                    groceries.Remove(item);
                    groceries.Add(item);
                }

                command = Console.ReadLine().Split(" ").ToArray();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
