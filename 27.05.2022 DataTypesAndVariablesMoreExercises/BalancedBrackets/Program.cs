using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            bool isOpenBracket = false;
            bool isClosedBracket = false;
            bool isBalancedBrackets = true;
            for (int i = 0; i < numberOfLines; i++)
            {
                string currentLine = Console.ReadLine();
                if (currentLine == "(")
                {
                    if (isOpenBracket)
                    {
                        isBalancedBrackets = false;
                        break;
                    }
                    isOpenBracket = true;
                }
                else if (currentLine == ")")
                {
                    isClosedBracket = true;
                    if (!isOpenBracket)
                    {
                        isBalancedBrackets = false;
                        break;
                    }
                }
                if ((isOpenBracket && isClosedBracket)||(!isOpenBracket && !isClosedBracket))
                {
                    isBalancedBrackets = true;
                    isOpenBracket = false;
                    isClosedBracket = false;
                }
                else
                {
                    isBalancedBrackets = false;
                }
            }
            if (isBalancedBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
