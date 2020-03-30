using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner0
{
    class Feladat3
    {
        public void Factorial()
        {
            int number;
            int fact = 1;

            Console.WriteLine("Please enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine("The factorial is: " + fact);

        }
    }
}
