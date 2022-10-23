using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> secondList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> longList = new List<double>();
            List<double> shortList = new List<double>();
            List<double> resultList = new List<double>();
            
            if (firstList.Count>secondList.Count)
            {
                longList = firstList;
                shortList = secondList;
            }
            else
            {
                longList = secondList;
                shortList = firstList;
            }

            for (int i = 0; i < shortList.Count*2; i++)
            {
                if (i%2==0)
                {
                    resultList.Add(firstList[i / 2]);
                }
                else
                {
                    resultList.Add(secondList[i / 2]);
                }
            }

            for (int i = shortList.Count; i < longList.Count; i++)
            {
                resultList.Add(longList[i]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
