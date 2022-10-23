using System;
using System.Text;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseCodeMessage = Console.ReadLine().Split(" | ");

            StringBuilder decodedMessage = new StringBuilder();

            foreach (var word in morseCodeMessage)
            {
                string[] letters = word.Split(" ");

                foreach (var letter in letters)
                {
                    switch (letter)
                    {
                        case ".-":
                            decodedMessage.Append("A");
                            break;
                        case "-...":
                            decodedMessage.Append("B");
                            break;
                        case "-.-.":
                            decodedMessage.Append("C");
                            break;
                        case "-..":
                            decodedMessage.Append("D");
                            break;
                        case ".":
                            decodedMessage.Append("E");
                            break;
                        case "..-.":
                            decodedMessage.Append("F");
                            break;
                        case "--.":
                            decodedMessage.Append("G");
                            break;
                        case "....":
                            decodedMessage.Append("H");
                            break;
                        case "..":
                            decodedMessage.Append("I");
                            break;
                        case ".---":
                            decodedMessage.Append("J");
                            break;
                        case "-.-":
                            decodedMessage.Append("K");
                            break;
                        case ".-..":
                            decodedMessage.Append("L");
                            break;
                        case "--":
                            decodedMessage.Append("M");
                            break;
                        case "-.":
                            decodedMessage.Append("N");
                            break;
                        case "---":
                            decodedMessage.Append("O");
                            break;
                        case ".--.":
                            decodedMessage.Append("P");
                            break;
                        case "--.-":
                            decodedMessage.Append("Q");
                            break;
                        case ".-.":
                            decodedMessage.Append("R");
                            break;
                        case "...":
                            decodedMessage.Append("S");
                            break;
                        case "-":
                            decodedMessage.Append("T");
                            break;
                        case "..-":
                            decodedMessage.Append("U");
                            break;
                        case "...-":
                            decodedMessage.Append("V");
                            break;
                        case ".--":
                            decodedMessage.Append("W");
                            break;
                        case "-..-":
                            decodedMessage.Append("X");
                            break;
                        case "-.--":
                            decodedMessage.Append("Y");
                            break;
                        case "--..":
                            decodedMessage.Append("Z");
                            break;
                    }
                }

                decodedMessage.Append(" ");
            }

            Console.WriteLine(decodedMessage);
        }
    }
}
