
using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 10, 20, 10, 30, 20, 10 };

        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            bool checkedBefore = false;

            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    checkedBefore = true;
                    break;
                }
            }

            if (checkedBefore == false)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine(arr[i] + " = " + count);
            }
        }
    }
}
