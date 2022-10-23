using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWorkProjects
{
    class Team
    {
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;
            Members = new List<string>();
        }
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; } = new List<string>();

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");

                string creator = teamInfo[0];
                string name = teamInfo[1];

                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (teams.Any(x=>x.Name==name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }               
                else
                {
                    Team team = new Team(creator, name);

                    teams.Add(team);

                    Console.WriteLine($"Team {name} has been created by {creator}!");
                }
            }

            string[] command = Console.ReadLine().Split("->");

            while (command[0] != "end of assignment")
            {
                string member = command[0];
                string name = command[1];

                if (!teams.Any(x=>x.Name==name))
                {
                    Console.WriteLine($"Team {name} does not exist!");
                }
                else if (teams.Any(x=>x.Members.Contains(member)) || teams.Any(x => x.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {name}!");
                }
                else
                {
                    teams[teams.IndexOf(teams.First(x => x.Name == name))].Members.Add(member);
                }

                command = Console.ReadLine().Split("->");
            }

            List<Team> createdTeams = teams.Where(x => x.Members.Count != 0).ToList();
            List<Team> disboundedTeams = teams.Where(x => x.Members.Count == 0).ToList();

            foreach (var team in createdTeams.OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disboundedTeams.OrderBy(x=>x.Name))
            {
                Console.WriteLine(team.Name);
            }

        }
    }
}
