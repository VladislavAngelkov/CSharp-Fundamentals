using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Emoji
    {
        public Emoji(string emojiText, string emojiName)
        {
            EmojiText = emojiText;
            EmojiName = emojiName;
        }
        public string EmojiText { get; set; }
        public string EmojiName { get; set; }
        public BigInteger Coolness
        {
            get
            {
                BigInteger coolness = 0;
                for (int i = 0; i < EmojiName.Length; i++)
                {
                    coolness += EmojiName[i];
                }
                return coolness;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string emojiPattern = @"(?<sign>[:\*])\k<sign>(?<emoji>[A-Z][a-z]{2,})\k<sign>\k<sign>";
            Regex emojiRegex = new Regex(emojiPattern);
            MatchCollection emojies = emojiRegex.Matches(inputText);

            string digitPattern = @"\d";
            Regex digitRegex = new Regex(digitPattern);
            MatchCollection digits = digitRegex.Matches(inputText);

            BigInteger coolnessThreshold = 1;

            foreach (Match digit in digits)
            {
                coolnessThreshold *= int.Parse(digit.Value.ToString());
            }

            Console.WriteLine($"Cool threshold: {coolnessThreshold}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            
            List<Emoji> emojiCoolness = new List<Emoji>();

            foreach (Match emoji in emojies)
            {
                string emojiText = emoji.Value.ToString();
                string emojiName = emoji.Groups["emoji"].Value.ToString();
                Emoji currentEmoji = new Emoji(emojiText, emojiName);
                emojiCoolness.Add(currentEmoji);
            }

            foreach (var emoji in emojiCoolness.Where(x=>x.Coolness>=coolnessThreshold))
            {
                Console.WriteLine(emoji.EmojiText);
            }
        }
    }
}
