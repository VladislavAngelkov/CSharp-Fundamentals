using System;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string[] command = Console.ReadLine().Split("|");

            while (command[0] != "Decode")
            {
                string cmd = command[0];

                switch (cmd)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(command[1]);
                        encryptedMessage = Move(encryptedMessage, numberOfLetters);
                        break;

                    case "Insert":
                        int index = int.Parse(command[1]);
                        string value = command[2];
                        encryptedMessage = Insert(encryptedMessage, index, value);
                        break;

                    case "ChangeAll":
                        string substring = command[1];
                        string replacement = command[2];
                        encryptedMessage = encryptedMessage.Replace(substring, replacement);
                        break;
                }

                command = Console.ReadLine().Split("|");
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }

        public static string Move(string text, int numberOfLetters)
        {
            string substring = text.Substring(0, numberOfLetters);
            text = text.Remove(0, numberOfLetters);
            text += substring;
            return text;
        }

        public static string Insert(string text, int index, string substring)
        {
            //int startingIndex = index - 0;

            if (index>=0 && index<text.Length)
            {
                text = text.Insert(index, substring);
            }
            else
            {
                text += substring;
            }

            return text;
        }

        //public static string ChangeAll(string text, string substring, string replacement)
        //{
        //    text = text.Replace(substring, replacement);
        //    return text;
        //}
    }
}
