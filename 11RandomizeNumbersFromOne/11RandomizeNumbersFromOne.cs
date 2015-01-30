using System;

namespace RandomizeNumbersFromOne

    //Problem 12.* Randomize the Numbers 1…N
    //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

{
    class RandomizeNumbersFromOne
    {
        static void Main()
        {
            Console.Write("Entere Number: ");
            int n = int.Parse(Console.ReadLine());
            Random rdm = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", rdm.Next(1, n));
            }
            Console.WriteLine();
        }
    }
}
