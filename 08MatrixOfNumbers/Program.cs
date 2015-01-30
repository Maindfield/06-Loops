using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number[1..20]: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n <= 20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(row + col);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Inavalid Input!");
            }
        }
    }
}
