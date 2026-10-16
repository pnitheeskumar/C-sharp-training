using System;

class Program
{
    static void Main()
    {
        // Print Alphabet Triangle
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)('A' + j - 1));
            }

            Console.WriteLine();
        }
    }
}