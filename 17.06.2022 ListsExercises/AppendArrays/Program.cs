using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            List<string[]> result = new List<string[]>();

            for (int i = 0; i < input.Length; i++)
            {
                result.Add(input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }

            result.Reverse();

            List<string> text = new List<string>();

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    text.Add(result[i][j]);
                }
            }

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
