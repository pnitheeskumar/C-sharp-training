
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

        Console.Write("Enter K value: ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k < 1 || k > size)
        {
            Console.WriteLine("Invalid K value");
            return;
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

        Console.WriteLine("Kth Smallest: " + arr[k - 1]);
        Console.WriteLine("Kth Largest: " + arr[size - k]);
    }
}
