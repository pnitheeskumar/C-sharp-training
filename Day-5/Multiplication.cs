using System;

class Program
{
    static void Main()
    {
        // Multiplication Tables from 1 to 5
        for (int n = 1; n <= 5; n++)
        {
            Console.WriteLine("Table of " + n);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }

            Console.WriteLine();
        }
    }
}