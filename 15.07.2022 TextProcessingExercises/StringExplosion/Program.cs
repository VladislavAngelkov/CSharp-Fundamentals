using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    result.Append(input[i]);
                }
                else if (power!=0)
                {
                    power--;
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
