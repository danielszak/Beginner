using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner0
{
    class Feladat1
    {
        
        public void Divider()
        {

            int numbers=0;
            int start = 1;
            int stop = 100;

            for (int i = start ; i < stop; i++)
            {
                if (i % 3 == 0)
                {
                    numbers++;
                }
            }

            Console.WriteLine("There are "+ numbers + " numbers which you can divide by 3" );
        }
    }
}
