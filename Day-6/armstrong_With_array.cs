
using System;

public class Armstrong
{
    public static void Main(String[] args)
    {
        int size = 5;
        int[] arr = new int[size];

        for(int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }

        for(int z = 0; z < arr.Length; z++)
        {
            int n = arr[z];
            int temp = n;
            int count = 0;
            int sum = 0;

            while(temp > 0)
            {
                count++;
                temp = temp / 10;
            }

            temp = n;

            while(temp > 0)
            {
                int rem = temp % 10;
                int mul = 1;

                for(int i = 1; i <= count; i++)
                {
                    mul = mul * rem;
                }

                sum = sum + mul;
                temp = temp / 10;
            }

            if(n >= 0 && sum == n)
            {
                Console.WriteLine(n + " is Armstrong");
            }
            else
            {
                Console.WriteLine(n + " is not Armstrong");
            }
        }
    }
}
