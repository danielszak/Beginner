using System;

namespace Beginner3
{
    internal class Feladat3
    {
        public void Time()
        {
            string[] times;
            Console.WriteLine("Please enter the time in the 24-hour time format!");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            times = input.Split(':');

            if (times.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                int hour = Convert.ToInt32(times[0]);
                int minute = Convert.ToInt32(times[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}