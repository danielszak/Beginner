using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner2
{
    class Feladat2
    {
        public void Reverser()
        {
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            char[] reverse = name.ToCharArray();
            Array.Reverse(reverse);
             string final = new string(reverse);

            Console.WriteLine("Your name reversed is :" + final);

        }
    }
}
