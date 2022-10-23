using System;
using System.Linq;

namespace LadyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialPositions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int i = 0; i < fieldSize; i++)
            {
                if (initialPositions.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }
            string[] command = Console.ReadLine().Split(' ');
            while (command[0]!="end")
            {
                int ladyBugPosition = int.Parse(command[0]);
                string direction = command[1];
                int movementRange = int.Parse(command[2]);
                int newPosition = 0;
                if (ladyBugPosition<0 || ladyBugPosition>=fieldSize)
                {
                    command = Console.ReadLine().Split(' ');
                    continue;
                }
                if (field[ladyBugPosition]==0)
                {
                    command = Console.ReadLine().Split(' ');
                    continue;
                }
                if (direction=="right")
                {
                    newPosition = ladyBugPosition + movementRange;
                }
                else if (direction == "left")
                {
                    newPosition = ladyBugPosition - movementRange;
                }
                if (newPosition>=0 && newPosition<fieldSize)
                {
                    if (field[newPosition]==0)
                    {
                        field[newPosition] = 1;
                        field[ladyBugPosition] = 0;
                    }
                    else if (field[newPosition]==1)
                    {
                        while (field[newPosition]==1)
                        {
                            if (direction=="right")
                            {
                                newPosition += movementRange;
                                if (newPosition>=fieldSize || newPosition < 0)
                                {
                                    break;
                                }
                            }
                            else if (direction == "left")
                            {
                                newPosition -= movementRange;
                                if (newPosition >= fieldSize || newPosition < 0)
                                {
                                    break;
                                }
                            }
                        }
                        if (newPosition >= 0 && newPosition < fieldSize)
                        {
                            field[newPosition] = 1;
                            field[ladyBugPosition] = 0;
                        }
                        else
                        {
                            field[ladyBugPosition] = 0;
                        }

                    }
                }
                else
                {
                    field[ladyBugPosition] = 0;
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
