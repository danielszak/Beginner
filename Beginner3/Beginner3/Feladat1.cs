using System;
using System.Collections.Generic;

namespace Beginner3
{
    internal class Feladat1
    {
        private List<int> numbers = new List<int>();
        private bool consecutive = true;

        public void Consecutive()
        {
            Console.WriteLine("Please enter a few numbers separated by a hyphen (1-2-3-4)!");
            string input = Console.ReadLine();

            foreach (string number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();

            Sorting();
        }

        private void Sorting()
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    consecutive = false;
                    break;
                }

                consecutive = true;
            }

            if (consecutive == true)
                Console.WriteLine("The numbers are consecutive");
            else
                Console.WriteLine("The numbers are not consecutive");
        }
    }
}