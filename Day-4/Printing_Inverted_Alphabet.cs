using System;

class Program
{
    static void Main()
    {
        // Print Inverted Alphabet Triangle
        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)('A' + j - 1));
            }

            Console.WriteLine();
        }
    }
}