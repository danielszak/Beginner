using System;
using System.Collections.Generic;

namespace Beginner3
{
    internal class Feladat2
    {
        public void Duplicate()
        {
            List<int> numbers = new List<int>();
            List<int> uniqueNumbers = new List<int>();
            List<int> notUnique = new List<int>();

            Console.WriteLine("Please enter a few numbers separated by a hyphen");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                Environment.Exit(0);

            foreach (string number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }


            foreach (int number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
                else
                    notUnique.Add(number);
            }

            if(notUnique.Count>=1)
                Console.WriteLine("Duplicate");
        }
    }
}