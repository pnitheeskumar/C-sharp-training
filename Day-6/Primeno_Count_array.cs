
using System;

public class Prime
{
    public static void Main(String[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        int primeCount = 0;

        for(int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }

        for(int z = 0; z < arr.Length; z++)
        {
            int n = arr[z];
            int count = 0;

            if(n > 1)
            {
                for(int i = 2; i < n; i++)
                {
                    if(n % i == 0)
                    {
                        count++;
                    }
                }

                if(count == 0)
                {
                    primeCount++;
                }
            }
        }

        Console.WriteLine("Prime count = " + primeCount);
    }
}
