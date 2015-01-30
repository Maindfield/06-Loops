using System;
using System.Globalization;
using System.Threading;
using System.Numerics;

namespace CalculateN

    //Problem 7. Calculate N! / (K! * (N-K)!)
    //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
    //(also known as the number of combinations) is calculated by the following formula: formula For example,
    //there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
    //Try to use only two loops.

{
    class CalculateN
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number k: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger firstFact = 1;
            BigInteger secondFact = 1;

            if (1 < k && n > k && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    firstFact *= i;
                }
                for (int j = 1; j <= (n - k); j++)
                {
                    secondFact *= j;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            BigInteger result = firstFact / secondFact;
            Console.WriteLine("N! / K!(N-K)! = {0}", result);
        }
    }
}
