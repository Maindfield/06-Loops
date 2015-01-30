using System;

namespace RandomNumbers

    //Problem 11. Random Numbers in Given Range
    //Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

{
    class RandomNumbers
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter Min value of numbers:");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter Max value of numbers:");
            int max = int.Parse(Console.ReadLine());

            Random rdm = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", rdm.Next(min, max));
            }
        }
    }
}
