using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "no more time")
            {
                string user = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(user, points);
                }
                else if (!contests[contest].ContainsKey(user))
                {
                    contests[contest].Add(user, points);
                }
                else if (contests[contest][user]<points)
                {
                    contests[contest][user] = points;
                }

                if (!students.ContainsKey(user))
                {
                    students.Add(user, new Dictionary<string, int>());
                    students[user].Add(contest, points);
                }
                else if (!students[user].ContainsKey(contest))
                {
                    students[user].Add(contest, points);
                }
                else if (students[user][contest]<points)
                {
                    students[user][contest] = points;
                }

                input = Console.ReadLine().Split(" -> ");
            }

            //contests = contests.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            students = students.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var cont in contests)
            {
                Console.WriteLine($"{cont.Key}: {cont.Value.Count} participants");
                
                int contestCounter = 0;

                foreach (var user in cont.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    contestCounter += 1;
                    Console.WriteLine($"{contestCounter}. {user.Key} <::> {user.Value}");
                }
            }

            Console.WriteLine("Individual standings:");

            int StudentsCounter = 0;

            foreach (var stud in students)
            {
                StudentsCounter += 1;
                Console.WriteLine($"{StudentsCounter}. {stud.Key} -> {stud.Value.Values.Sum()}");
            }
        }
    }
}
