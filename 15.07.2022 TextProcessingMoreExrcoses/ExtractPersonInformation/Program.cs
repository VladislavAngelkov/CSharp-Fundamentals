using System;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string personInfo = Console.ReadLine();

                int nameStartingIndex = personInfo.IndexOf('@') + 1;
                int nameEndIndex = personInfo.IndexOf('|') - 1;
                int nameLength = nameEndIndex - nameStartingIndex + 1;
                string name = personInfo.Substring(nameStartingIndex, nameLength);

                int ageStartingIndex = personInfo.IndexOf('#') + 1;
                int ageEndIndex = personInfo.IndexOf('*') - 1;
                int ageLength = ageEndIndex - ageStartingIndex + 1;
                string age = personInfo.Substring(ageStartingIndex, ageLength);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
