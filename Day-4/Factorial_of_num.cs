using System;

class Program
{
    static void Main()
    {
        // Find Factorial of a Number
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        long fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}