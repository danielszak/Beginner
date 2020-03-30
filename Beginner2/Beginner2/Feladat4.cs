using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner2
{
    class Feladat4
    {
        public void UniqueList()
        {
            List<int> numbers = new List<int>();
            List<int> uniqueNumbers = new List<int>();
            bool valid = true;

            while (valid)
            {
                Console.WriteLine("Enter a number ot type 'quit' to quit:");
                string enteredNumber = Console.ReadLine();
                if (enteredNumber.ToLower() == "quit" || enteredNumber=="")
                {
                    valid=false;
                }
                else
                {
                    int number = Convert.ToInt32(enteredNumber);
                    numbers.Add(number);
                }
             
                
            }

            foreach (int number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }
            Console.WriteLine("The unique numbers are: ");
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine( number);
            }


        }
    }
}
