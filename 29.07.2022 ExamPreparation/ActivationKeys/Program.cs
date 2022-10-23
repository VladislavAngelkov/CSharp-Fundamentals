using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string[] command = Console.ReadLine().Split(">>>");

            while (command[0] != "Generate")
            {
                string cmd = command[0];

                switch (cmd)
                {
                    case "Contains":
                        string substring = command[1];
                        ContainsSubstring(activationKey, substring);
                        break;
                    case "Flip":
                        string UpperOrLower = command[1];
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        activationKey = Flip(activationKey, UpperOrLower, startIndex, endIndex);
                        break;
                    case "Slice":
                        int startingIndex = int.Parse(command[1]);
                        int endingIndex = int.Parse(command[2]);
                        activationKey = Slice(activationKey, startingIndex, endingIndex);
                        break;
                }

                command = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        private static string Slice(string text, int startIndex, int endIndex)
        {
            text = text.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(text);

            return text;
        }

        private static string Flip(string text, string UpperOrLower, int startIndex, int EndIndex)
        {
            string substring = text.Substring(startIndex, EndIndex - startIndex);

            string newSubstring = "";

            if (UpperOrLower == "Upper")
            {
                 newSubstring = substring.ToUpper();
            }
            else if (UpperOrLower == "Lower")
            {
                 newSubstring = substring.ToLower();
            }

            text = text.Remove(startIndex, EndIndex - startIndex);
            text = text.Insert(startIndex, newSubstring);

            Console.WriteLine(text);

            return text;
        }

        private static void ContainsSubstring(string text, string substring)
        {
            if (text.Contains(substring))
            {
                Console.WriteLine($"{text} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}
