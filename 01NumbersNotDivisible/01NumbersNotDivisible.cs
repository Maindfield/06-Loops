﻿using System;

namespace NumbersNotDivisible

    //Problem 2. Numbers Not Divisible by 3 and 7
    //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not
    //divisible by 3 and 7, on a single line, separated by a space.

{
    class NumbersNotDivisible
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
 
            for (int i = 1; i <= n; i++) 
            {
                if (!(i % 7 == 0 || i % 3 == 0))
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}
