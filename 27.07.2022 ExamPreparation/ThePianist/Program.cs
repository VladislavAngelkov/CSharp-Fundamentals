using System;
using System.Collections.Generic;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, string> pieceAndComposer = new Dictionary<string, string>();
            Dictionary<string, string> pieceAndKey = new Dictionary<string, string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split("|");

                string piece = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                pieceAndComposer.Add(piece, composer);
                pieceAndKey.Add(piece, key);
            }

            string[] command = Console.ReadLine().Split("|");

            while (command[0] != "Stop")
            {
                string cmd = command[0];
                string alteredPiece = command[1];

                switch (cmd)
                {
                    case "Add":
                        string newComposer = command[2];
                        string newKey = command[3];
                        
                        if (!pieceAndComposer.ContainsKey(alteredPiece))
                        {
                            pieceAndComposer.Add(alteredPiece, newComposer);
                            pieceAndKey.Add(alteredPiece, newKey);
                            Console.WriteLine($"{alteredPiece} by {pieceAndComposer[alteredPiece]} in {pieceAndKey[alteredPiece]} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{alteredPiece} is already in the collection!");
                        }
                        break;

                    case "Remove":
                        if (pieceAndComposer.ContainsKey(alteredPiece))
                        {
                            pieceAndComposer.Remove(alteredPiece);
                            pieceAndKey.Remove(alteredPiece);
                            Console.WriteLine($"Successfully removed {alteredPiece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {alteredPiece} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        string keyForChange = command[2];
                        if (pieceAndKey.ContainsKey(alteredPiece))
                        {
                            pieceAndKey[alteredPiece] = keyForChange;
                            Console.WriteLine($"Changed the key of {alteredPiece} to {keyForChange}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {alteredPiece} does not exist in the collection.");
                        }
                        break;
                }

                command = Console.ReadLine().Split("|");
            }

            foreach (var piece in pieceAndComposer)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {pieceAndKey[piece.Key]}");
            }
        }
    }
}
