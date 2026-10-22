
using System;

public class Odd
{
    public static void Main(String[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        int sum = 0;

        for(int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }

        for(int z = 0; z < arr.Length; z++)
        {
            if(arr[z] % 2 != 0)
            {
                sum = sum + arr[z];
            }
        }

        Console.WriteLine("Odd sum = " + sum);
    }
}
