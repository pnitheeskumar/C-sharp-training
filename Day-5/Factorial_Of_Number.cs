using System;

class Program
{
    static void Main()
    {
        
        for (int n = 1; n <= 10; n++)
        {
            long fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine(n + "! = " + fact);
        }
    }
}