
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

        Console.WriteLine("Reverse Array:");

        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
