
using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 50, 10, 40, 20, 30 };

        Console.Write("Enter K value: ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k < 1 || k > arr.Length)
        {
            Console.WriteLine("Invalid K value");
            return;
        }

        int temp;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Kth Smallest: " + arr[k - 1]);
        Console.WriteLine("Kth Largest: " + arr[arr.Length - k]);
    }
}
