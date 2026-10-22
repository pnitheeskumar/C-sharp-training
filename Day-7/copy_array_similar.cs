
using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[size];
        int[] arr2 = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element: ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            arr2[i] = arr1[i];
        }

        bool same = true;

        for (int i = 0; i < size; i++)
        {
            if (arr1[i] != arr2[i])
            {
                same = false;
                break;
            }
        }

        if (same == true)
        {
            Console.WriteLine("Both arrays are similar");
        }
        else
        {
            Console.WriteLine("Both arrays are not similar");
        }
    }
}
