using System;
using System.Linq;

namespace LadyBugSecondAttempt
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
            while (command[0] != "end")
            {
                int initialLadyBugPosition = int.Parse(command[0]);
                string direction = command[1];
                int movementRange = int.Parse(command[2]);
                int currentLadyBugPosition = initialLadyBugPosition;
                if (direction == "right")
                {
                    currentLadyBugPosition += movementRange;
                }
                else if (direction == "left")
                {
                    currentLadyBugPosition -= movementRange;
                }
                if (initialLadyBugPosition<0 || initialLadyBugPosition>=fieldSize)
                {
                    command = Console.ReadLine().Split(' ');
                    continue;
                }
                if (movementRange == 0)
                {
                    command = Console.ReadLine().Split(' ');
                    continue;
                }
                else
                {
                    while (currentLadyBugPosition >= 0 && currentLadyBugPosition < fieldSize && field[initialLadyBugPosition] == 1)
                    {
                        if (field[currentLadyBugPosition] == 0)
                        {
                            field[currentLadyBugPosition] = 1;
                            break;
                        }
                        else
                        {
                            if (direction == "right")
                            {
                                currentLadyBugPosition += movementRange;
                            }
                            else if (direction == "left")
                            {
                                currentLadyBugPosition -= movementRange;
                            }
                        }
                    }
                    field[initialLadyBugPosition] = 0;
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
