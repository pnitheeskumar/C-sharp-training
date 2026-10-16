using System;

class Program
{
    static void Main()
    {
        // Perfect Numbers from 1 to 100
        for (int n = 1; n <= 100; n++)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }

            if (sum == n)
                Console.Write(n + " ");
        }
    }
}