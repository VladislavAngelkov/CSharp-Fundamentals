using System;

namespace GamingScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double gamePrice = 0;
            double spendings = 0;
            while (command!= "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (gamePrice<=balance && gamePrice!=0)
                {
                    balance -= gamePrice;
                    spendings += gamePrice;
                    Console.WriteLine($"Bought {command}");
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else if (gamePrice>balance)
                {
                    Console.WriteLine("Too Expensive");
                }
                gamePrice = 0;
                command = Console.ReadLine();  
            }
            Console.WriteLine($"Total spent: ${spendings:f2}. Remaining: ${balance:f2}");
        }
    }
}
//OutFall 4   $39.99
//CS: OG  $15.99
//Zplinter Zell	$19.99
//Honored 2	$59.99
//RoverWatch	$29.99
//RoverWatch Origins Edition	$39.99
