using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case "char":
                    Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
                    break;
                case "string":
                    Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));
                    break;
            }
        }
        public static int GetMax(int firstInput, int secondInput)
        {
            int result = 0;
            if (firstInput>secondInput)
            {
                result = firstInput;
            }
            else if (secondInput>firstInput)
            {
                result = secondInput;
            }
            return result;
        }
        public static char GetMax(char firstInput, char secondInput)
        {
            char result = 'a';
            if (firstInput > secondInput)
            {
                result = firstInput;
            }
            else if (secondInput > firstInput)
            {
                result = secondInput;
            }
            return result;
        }
        public static string GetMax(string firstInput, string secondInput)
        {
            string result = "";
            int shortestLength = 0;
            if (firstInput.Length>secondInput.Length)
            {
                shortestLength = secondInput.Length;
                result = firstInput;
            }
            else
            {
                shortestLength = firstInput.Length;
                result = secondInput;
            }
            for (int i = 0; i < shortestLength; i++)
            {
                if (firstInput[i]>secondInput[i])
                {
                    result = firstInput;
                    return result;
                    break;
                }
                else if (secondInput[i]>firstInput[i])
                {
                    result = secondInput;
                    return result;
                    break;
                }
            }
            return result;
        }
    }
}
