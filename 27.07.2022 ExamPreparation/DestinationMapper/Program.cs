using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<sign>[=\/])(?<stop>[A-Z][A-Za-z]{2,})\k<sign>";
            Regex regex = new Regex(pattern);
            string stops = Console.ReadLine();
            MatchCollection validStops = regex.Matches(stops);

            int travelPoints = 0;

            List<string> finalStops = new List<string>();

            foreach (Match match in validStops)
            {
                travelPoints += match.Groups["stop"].Value.Length;
                finalStops.Add(match.Groups["stop"].Value);
            }

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", finalStops));
            Console.WriteLine($"Travel Points: {travelPoints}");
            
        }
    }
}
