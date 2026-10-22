
using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int temp;

        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Ascending Order:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nDescending Order:");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
