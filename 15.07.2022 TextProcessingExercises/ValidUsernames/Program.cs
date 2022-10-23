using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var username in usernames)
            {
                bool isValid = true;

                if (username.Length<=3 || username.Length>=16)
                {
                    isValid = false;
                }

                for (int i = 0; i < username.Length; i++)
                {
                    if (!char.IsDigit(username[i]) && !char.IsLetter(username[i]) && username[i]!='_' && username[i]!='-')
                    {
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
