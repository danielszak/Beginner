using System;
using System.Collections.Generic;
using System.IO;

namespace Beginner4
{
    internal class Feladat2
    {
        public void LongestWord()
        {
            List<string> words = new List<string>();

            StreamReader streamReader = new StreamReader("text.txt");
            while (!streamReader.EndOfStream)
            {
                string content = streamReader.ReadLine();
                string[] strContent = content.Split(' ');
                foreach (string word in strContent)
                {
                    words.Add(word);
                }
            }

            int max = 0;
            string longestWord = "";

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    longestWord = words[i];
                }
            }
            Console.WriteLine("The longest word is: " + longestWord);
            Console.ReadKey();
        }
    }
}