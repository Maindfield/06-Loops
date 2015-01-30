using System;
using System.Threading;
using System.Globalization;

namespace Calculate

    //Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
    //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    //Use only one loop. Print the result with 5 digits after the decimal point.

{
    class Calculate
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number x: ");
            int x = int.Parse(Console.ReadLine());

            double factoriel = 1;
            double sqare = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++) 
              { 
                factoriel *= i ;
                sqare *= x;
                sum += (factoriel/sqare); 
              }
            Console.WriteLine("The result is: {0:F5}", sum);
        }
    }
}
