
using System;

public class Program
{
    public static void Main()
    {
        int[] arr1 = { 10, 20, 30, 40, 50 };
        int[] arr2 = new int[arr1.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr2[i] = arr1[i];
        }

        Console.WriteLine("Copied Array:");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
    }
}
