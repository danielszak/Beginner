using System;
using System.Collections.Generic;

namespace Beginner3
{
    internal class Feladat5
    {
        public void VowelCounter()
        {
            List<char> vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });

            Console.WriteLine("Please enter an English word");
            string input = Console.ReadLine();

            int vowelsCount = 0;
            foreach (char character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}