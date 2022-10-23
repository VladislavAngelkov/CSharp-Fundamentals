using System;
using System.Text;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string[] command = Console.ReadLine().Split(":");

            while (command[0] != "Travel")
            {
                string cmd = command[0];

                switch (cmd)
                {
                    case "Add Stop":
                        int index = int.Parse(command[1]);
                        string substring = command[2];
                        stops = AddStop(stops, index, substring);
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        stops = RemoveStop(stops, startIndex, endIndex);
                        break;

                    case "Switch":
                        string oldString = command[1];
                        string newString = command[2];
                        stops = Switch(stops, oldString, newString);
                        break;
                }

                command = Console.ReadLine().Split(":");
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        public static string AddStop(string text, int index, string substring)
        {
            if (index >= 0 && index < text.Length)
            {
                text = text.Insert(index, substring);
            }

            Console.WriteLine(text);

            return text;
        }

        public static string RemoveStop(string text, int startIndex, int endIndex)
        {
            //if (startIndex>endIndex)
            //{
            //    int temp = endIndex;
            //    endIndex = startIndex;
            //    startIndex = temp;
            //}

            if (startIndex >= 0 && startIndex < text.Length && endIndex >= 0 && endIndex < text.Length && endIndex >= startIndex)
            {
                int removetTextLength = endIndex - startIndex + 1;
                text = text.Remove(startIndex, removetTextLength);
            }

            Console.WriteLine(text);

            return text;
        }

        public static string Switch(string text, string oldString, string newString)
        {
            if (text.Contains(oldString))
            {
                text = text.Replace(oldString, newString);
            }

            Console.WriteLine(text);

            return text;
        }
    }
}
