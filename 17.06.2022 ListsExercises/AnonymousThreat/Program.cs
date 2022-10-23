using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "3:1")
            {
                string action = command[0];
                if (action == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= data.Count)
                    {
                        endIndex = data.Count - 1;
                    }
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        data[startIndex] += data[i];
                    }

                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        data.RemoveAt(startIndex + 1);
                    }
                }
                else if (action == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    int partitionsLength = data[index].Length / partitions;
                    string text = data[index];
                    List<string> partitionList = new List<string>();
                    int partitionStartIndex = 0;
                    for (int i = 0; i < partitions-1; i++)
                    {
                        partitionList.Add(text.Substring(partitionStartIndex, partitionsLength));
                        partitionStartIndex += partitionsLength;
                    }
                    partitionList.Add(text.Substring(partitionStartIndex));
                    data.RemoveAt(index);
                    for (int i = 0; i < partitionList.Count; i++)
                    {
                        data.Insert(index, partitionList[i]);
                        index++;
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
