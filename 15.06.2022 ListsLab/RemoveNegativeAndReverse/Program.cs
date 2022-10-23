using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList().Where(x => x >= 0).Reverse().ToList();
            Console.WriteLine(numbers.Count==0? "empty": string.Join(" ", numbers));
        }
    }
}
