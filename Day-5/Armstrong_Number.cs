using System;

class Program
{
    static void Main()
    {
        // Armstrong Numbers from 100 to 2000
        for (int n = 100; n <= 2000; n++)
        {
            int temp = n;
            int digits = n.ToString().Length;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                int power = 1;

                for (int i = 1; i <= digits; i++)
                {
                    power *= digit;
                }

                sum += power;
                temp /= 10;
            }

            if (sum == n)
                Console.Write(n + " ");
        }
    }
}