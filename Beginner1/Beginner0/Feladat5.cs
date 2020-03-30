using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner0
{
    class Feladat5
    {
        public void Max()
        {
            string[] numbers;
            string input;
            int max;

            Console.WriteLine("Enter the numbers separated by commas: ");
            input = Console.ReadLine();

            numbers= input.Split(',');
            max = Convert.ToInt32(numbers[0]);

            foreach (string strNumber in numbers)
            {
                int number = Convert.ToInt32(strNumber);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("The max number is: " + max);
        }
    }
}
