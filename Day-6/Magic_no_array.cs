
using System;

public class Magic
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

            while(n > 9)
            {
                int sum = 0;

                while(n > 0)
                {
                    int rem = n % 10;
                    sum = sum + rem;
                    n = n / 10;
                }

                n = sum;
            }

            if(n == 1)
            {
                Console.WriteLine(arr[z] + " is Magic");
            }
            else
            {
                Console.WriteLine(arr[z] + " is not Magic");
            }
        }
    }
}
