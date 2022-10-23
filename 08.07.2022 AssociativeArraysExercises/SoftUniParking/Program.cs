using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(" ");

                string user = command[1];

                if (command[0] == "register")
                {
                    string plate = command[2];

                    if (!registeredUsers.ContainsKey(user))
                    {
                        registeredUsers.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (registeredUsers.ContainsKey(user))
                    {
                        registeredUsers.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
