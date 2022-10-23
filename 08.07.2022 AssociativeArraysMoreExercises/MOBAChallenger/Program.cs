using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                string[] command = input.Split(" -> ");

                if (command.Length == 3)
                {
                    string player = command[0];
                    string position = command[1];
                    int skill = int.Parse(command[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                        players[player].Add(position, skill);
                    }
                    else if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);
                    }
                    else
                    {
                        if (players[player][position] < skill)
                        {
                            players[player][position] = skill;
                        }
                    }
                }
                else
                {
                    string[] battlingPlayers = command[0].Split(" ").ToArray();

                    string playerOne = battlingPlayers[0];
                    string playerTwo = battlingPlayers[2];

                    if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        bool commonPosition = false;

                        foreach (var skill in players[playerOne])
                        {
                            if (players[playerTwo].ContainsKey(skill.Key))
                            {
                                commonPosition = true;
                                break;
                            }
                        }

                        if (commonPosition)
                        {
                            if (players[playerOne].Values.Sum() > players[playerTwo].Values.Sum())
                            {
                                players.Remove(playerTwo);
                            }
                            else if (players[playerOne].Values.Sum() < players[playerTwo].Values.Sum())
                            {
                                players.Remove(playerOne);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            players = players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
