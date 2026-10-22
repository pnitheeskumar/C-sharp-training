
using System;

public class Even
{
    public static void Main(String[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        int count = 0;

        for(int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }

        for(int z = 0; z < arr.Length; z++)
        {
            if(arr[z] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Even count = " + count);
    }
}
