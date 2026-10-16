using System;

class Program
{
    static void Main()
    {
        // Multiplication Table
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}