using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int s = 1; s <= 5 - i; s++)
            {
                Console.Write("  ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)('A' + j - 1) + " ");
            }

            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write((char)('A' + j - 1) + " ");
            }

            Console.WriteLine();
        }
    }
}