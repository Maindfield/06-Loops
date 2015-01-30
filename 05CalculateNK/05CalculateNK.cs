using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

namespace CalculateNK

    //Problem 6. Calculate N! / K!
    //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    //Use only one loop.

{
    class CalculateNK
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number k: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            if (n <= 100 && k > 1)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
            Console.WriteLine("N!/K!= {0}", result);
        }
    }
}
