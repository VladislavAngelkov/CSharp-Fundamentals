using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int targetCounter = 0;

            while (command != "End")
            {
                int targetIndex = int.Parse(command);
                if (targetIndex>=0 && targetIndex<targets.Length)
                {
                    if (targets[targetIndex]!=-1)
                    {
                        targetCounter++;
                        targets[targetIndex] = -1;
                        
                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i]> targets[targetIndex] && targets[i]!=-1)
                            {
                                targets[i] -= targets[targetIndex];
                            }
                            else if (targets[i]< targets[targetIndex] && targets[i] != -1)
                            {
                                targets[i] += targets[targetIndex];
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.Write($"Shot targets: {targetCounter} -> {string.Join(" ", targets)}");
            //Console.WriteLine(string.Join(" ", targets));
        }
    }
}
