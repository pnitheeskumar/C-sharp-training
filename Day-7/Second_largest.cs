
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

        int largest = int.MinValue;
        int second = int.MinValue;
        bool found = false;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] > largest)
            {
                second = largest;
                largest = arr[i];
                found = (i > 0);
            }
            else if (arr[i] < largest && (!found || arr[i] > second))
            {
                second = arr[i];
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine("Second Largest: " + second);
        }
        else
        {
            Console.WriteLine("Second largest not found");
        }
    }
}
