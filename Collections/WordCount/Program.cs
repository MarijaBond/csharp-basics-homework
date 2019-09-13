using System;
using System.IO;
using System.Collections.Generic;

namespace WordCount
{
    class Program
    {
        private const string Path = "../WordCount/lear.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            List<char> textList = new List<char>();
            int charCount = 0;
            int wordCount = 0;
            int lineCount = 0;

            foreach (var s in readText)
            {
                Console.WriteLine(s);
                string x = Convert.ToString(s);
                char[] a = x.ToCharArray();
                foreach (var character in a)
                {
                    if (char.IsWhiteSpace(character))
                    {
                        wordCount++;
                        continue;
                    }
                    if (!char.IsWhiteSpace(character))
                    {
                        textList.Add(character);
                    }
                    lineCount++;
                }
            }

           
            foreach (char c in textList)
            {
                if (!char.IsWhiteSpace(c))
                {
                    charCount++;
                }
            }
            Console.WriteLine("Number of characters in Lear: " + charCount);
            Console.WriteLine("Number of words in Lear: " + wordCount);
            Console.WriteLine("Number of lines in Lear: " + lineCount);

        }
    }
}