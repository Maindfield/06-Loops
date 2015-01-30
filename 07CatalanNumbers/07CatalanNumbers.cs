using System;
using System.Numerics;

namespace CatalanNumbers

    //Problem 8. Catalan Numbers
    //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).


{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger upDiv = 1;
            BigInteger downDivider = 1;

            if (n >= 0 && n < 100)
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    upDiv *= i;
                }
                for (int j = 1; j <= n; j++)
                {
                    downDivider *= j;
                }

                BigInteger result = upDiv / downDivider;
                Console.WriteLine("The result is: " + result);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
