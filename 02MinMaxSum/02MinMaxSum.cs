using System;
using System.Threading;
using System.Globalization;

namespace MinMaxSum

    //Problem 3. Min, Max, Sum and Average of N Numbers
    //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
    //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.


{
    class MinMaxSum
    {
        static void Main()
        {
         
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

                Console.Write("Enter positive nubmers: ");
                int count = int.Parse(Console.ReadLine());

                int min = int.MaxValue;
                int max = int.MinValue;
                int sum = 0;

                for (int i = 1; i <= count; i++)
                {
                  Console.Write("Enter integer {0}:",i);
                  int number = int.Parse(Console.ReadLine());
                     if (number>max)
                     {
                         max = number;
                     }
                     if (number<min)
                     {
                         min = number;
                     }
                         sum = sum + number;
                     }

                double avg = (double)sum / count;
                Console.WriteLine("min={0}\nmax={1}\nsum={2}\naverage={3:F2}",min,max,sum,avg);
        }    
   }
}
        
    

