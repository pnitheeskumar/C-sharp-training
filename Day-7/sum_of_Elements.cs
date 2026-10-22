
using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            sum = sum + arr[i];
        }

        Console.WriteLine("Sum of Array: " + sum);
    }
}
