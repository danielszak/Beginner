using System;
using System.Collections.Generic;

namespace Beginner2
{
    internal class Feladat1
    {
        public void FaceBook()
        {
            bool valid = true;
            List<String> names = new List<string>();

            while (valid)
            {
                Console.WriteLine("Enter a name: ");
                string name = Console.ReadLine();

                if (name == null || name == "")
                    valid = false;
                else
                    names.Add(name);
            }

            if(names.Count == 0)
                Console.WriteLine();
            else if(names.Count == 1)
                Console.WriteLine("{0} likes your post", names[0]);
            else if(names.Count == 2)
                Console.WriteLine("{0} and {1} likes your post", names[0], names[1]);
            else if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} other people likes your post", names[0],names[1], names.Count-2);
        }
    }
}