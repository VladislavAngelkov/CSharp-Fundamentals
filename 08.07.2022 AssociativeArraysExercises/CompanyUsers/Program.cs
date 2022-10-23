using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string[] command = Console.ReadLine().Split(" -> ");

            while (command[0] != "End")
            {
                string company = command[0];
                string employee = command[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                if (!companies[company].Contains(employee))
                {
                    companies[company].Add(employee);
                }

                command = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
