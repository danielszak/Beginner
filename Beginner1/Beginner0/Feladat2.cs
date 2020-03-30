using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner0
{
    class Feladat2
    {
        public void NumberGen()
        {
            bool valid = true;
            int sum = 0;

            while (valid)
            {
                Console.WriteLine("Enter a number or type OK to exit");
                string choice = Console.ReadLine();
                if (choice == "ok")
                    break;

                sum += Convert.ToInt32(choice);
            }

            Console.WriteLine("The sum of the entered numbers are: " + sum);
        }


    }
}
