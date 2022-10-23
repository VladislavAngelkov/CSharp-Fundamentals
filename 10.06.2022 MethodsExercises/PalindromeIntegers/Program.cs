using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Palindrome(input);
                input = Console.ReadLine();
            }
        }
        static void Palindrome(string number)
        {
            bool isPalindrome = true;
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }
            Console.WriteLine(isPalindrome.ToString().ToLower());
        }
    }
}
