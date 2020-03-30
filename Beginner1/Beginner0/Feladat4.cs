using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner0
{
    class Feladat4
    {
        public void Guess()
        {
            int rand = new Random().Next(1, 10);
            int guesses = 4;

            //Console.WriteLine("The number is:" + rand);

            while(guesses != 0)
            {
                Console.WriteLine("Guess the number!");
                int guessNumber = Convert.ToInt32(Console.ReadLine());

                if(guessNumber == rand)
                {
                    Console.WriteLine("You won");
                    break;
                }

                else
                {
                    Console.WriteLine("Wrong number");
                    guesses--;
                }
            }
            if(guesses ==0)
                Console.WriteLine("You lost");
        }
        
    }
}
