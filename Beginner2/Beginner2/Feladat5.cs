using System;
using System.Collections.Generic;

namespace Beginner2
{
    internal class Feladat5

    {
        private List<int> numbers = new List<int>();
        private List<int> smallests = new List<int>();
        private string[] inputs;
        private bool valid = true;

        public void NumberList()
        {
            while (valid)
            {
                Console.WriteLine("Enter the numbers separated by commas: ");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    inputs = input.Split(',');
                }

                if (inputs.Length <= 5)
                {
                    valid = false;
                    Console.WriteLine("Invalid list. Want to restart the application?[y] or [n]");
                    string choice = Console.ReadLine();

                    if (choice == "y")
                        valid = true;
                }
                else
                {
                    Put();
                    break;
                }
            }
        }

        private void Put()
        {
            foreach (string number in inputs)
            {
                numbers.Add(Convert.ToInt32(number));
            }
            Smallest();
        }

        private void Smallest()
        {
            while (smallests.Count < 3)
            {
                int min = numbers[0];
                foreach (int number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (int number in smallests)
                Console.WriteLine(number);
        }
    }
}