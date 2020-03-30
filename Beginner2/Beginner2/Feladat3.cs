using System;
using System.Collections.Generic;

namespace Beginner2
{
    internal class Feladat3
    {
        public void Unique()
        {
            List<int> numbers = new List<int>();

            while (numbers.Count <= 5)
            {
                Console.WriteLine("Please enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've already entered this number, please enter another one.");
                }
                numbers.Add(number);
            }
            numbers.Sort();
            Console.WriteLine("Your sorted numbers are: ");
            foreach (int number in numbers)
                Console.WriteLine(number);
        }
    }
}