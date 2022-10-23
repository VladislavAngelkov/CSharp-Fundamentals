using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Contestant
    {

        public Dictionary<string, int> Results { get; set; }

        public int TotalPoints
        {
            get
            {
                int totalPoints = 0;

                foreach (var contest in this.Results)
                {
                    totalPoints += contest.Value;
                }

                return totalPoints;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string[] contestsInfo = Console.ReadLine().Split(":"); 

            while (contestsInfo[0]!= "end of contests")
            {
                string contestName = contestsInfo[0];
                string contestPass = contestsInfo[1];

                contests.Add(contestName, contestPass);

                contestsInfo = Console.ReadLine().Split(":");
            }

            string[] userInfo = Console.ReadLine().Split("=>");

            Dictionary<string, Contestant> contestants = new Dictionary<string, Contestant>();

            

            while (userInfo[0] != "end of submissions")
            {
                string contestName = userInfo[0];
                string contestPass = userInfo[1];
                string userName = userInfo[2];
                int points = int.Parse(userInfo[3]);

                if (contests.ContainsKey(contestName))
                {
                    if (contests[contestName] == contestPass)
                    {
                        if (!contestants.ContainsKey(userName))
                        {
                            Dictionary<string, int> results = new Dictionary<string, int>();
                            Contestant cont = new Contestant();
                            cont.Results = results;
                            contestants.Add(userName, cont);
                        }

                        if (!contestants[userName].Results.ContainsKey(contestName))
                        {
                            contestants[userName].Results.Add(contestName, points);
                        }
                        else if (contestants[userName].Results[contestName]<=points)
                        {
                            contestants[userName].Results[contestName] = points;
                        }
 
                    }
                }

                userInfo = Console.ReadLine().Split("=>");
            }

            contestants = contestants.OrderByDescending(x => x.Value.TotalPoints).ToDictionary(x => x.Key, y => y.Value);

            string bestContestant = contestants.First().Key;

            Console.WriteLine($"Best candidate is {bestContestant} with total {contestants[bestContestant].TotalPoints} points.");

            Console.WriteLine("Ranking:");

            foreach (var contestant in contestants.OrderBy(x => x.Key))
            {
                Console.WriteLine(contestant.Key);

                foreach (var contest in contestant.Value.Results.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

        }
    }
}
