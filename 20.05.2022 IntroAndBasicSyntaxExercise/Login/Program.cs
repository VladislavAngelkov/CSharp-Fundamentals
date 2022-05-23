using System;
using System.Text;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string realPassword = "";
            for (int i = userName.Length-1; i >= 0; i--)
            {
                realPassword += userName[i];
            }
            string password = Console.ReadLine();
            int counter = 0;
            bool isLogged = true;
            while (password!=realPassword)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    isLogged = false;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }
            if (isLogged)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
           
        }
    }
}
// User {username} blocked!