using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int battleCounter = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (distance<=initialEnergy)
                {
                    battleCounter++;
                    initialEnergy -= distance;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleCounter} won battles and {initialEnergy} energy");
                    return;
                }

                if (battleCounter%3==0)
                {
                    initialEnergy += battleCounter;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {battleCounter}. Energy left: {initialEnergy}");
        }
    }
}
