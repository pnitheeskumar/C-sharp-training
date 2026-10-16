using System;

class Program
{
    static void Main()
    {
        // Print Right-Angled Triangle Using #
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}