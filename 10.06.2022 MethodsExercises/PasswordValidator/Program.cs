using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator(Console.ReadLine());
        }
        public static void PasswordValidator(string password)
        {
            int digitCounter = 0;
            bool containsUnalowedChar = false;
            bool incorrectLength = false;
            bool isValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                incorrectLength = true;
                isValid = false;
                
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitCounter++;
                }
                else if (!char.IsLetter(password[i]))
                {
                    containsUnalowedChar = true;
                    isValid = false;
                }
            }
            if (incorrectLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (containsUnalowedChar)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digitCounter < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
