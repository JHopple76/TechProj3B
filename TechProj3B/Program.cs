// Name: T. Jarrett Hopple
// Class: ISM 4300
// Assignment: Tech Project 3B

using System;

namespace TechProj3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manually populated data");

            // manually populated array
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
            foreach (var item in array)
            {
                // shows the array values
                Console.WriteLine("Element value = " + item);
            }

            // end of program
            Console.ReadKey(true);
        }

    }
}

