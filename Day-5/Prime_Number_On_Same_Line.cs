using System;

class Program
{
    static void Main()
    {
        // Prime Numbers from 1 to 100
        for (int n = 2; n <= 100; n++)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }

            if (count == 2)
                Console.Write(n + " ");
        }
    }
}