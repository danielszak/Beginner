using System;
using System.Collections.Generic;
using System.IO;

namespace Beginner4
{
    internal class Feladat1
    {
        public void CharNumber()
        {
            List<char> words = new List<char>();

            StreamReader streamReader = new StreamReader("text.txt");
            while (!streamReader.EndOfStream)
            {
                string content = streamReader.ReadLine();
                content.Split(' ');
                foreach (char word in content)
                {
                    words.Add(word);
                }
            }

            Console.WriteLine("The number of characters is: {0}", words.Count);

            Console.ReadKey();
        }
    }
}