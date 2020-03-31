using System;

namespace Beginner3
{
    internal class Feladat4
    {
        public void Words()
        {
            Console.WriteLine("Please enter a few words separated by space!");
            string input = Console.ReadLine();

            string inputName = "";
            foreach (string word in input.Split(' '))
            {
                string wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                inputName += wordWithPascalCase;
            }

            Console.WriteLine(inputName);
        }
    }
}