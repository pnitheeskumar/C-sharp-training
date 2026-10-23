
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        int count = 0;

        if (sub.Length > 0)
        {
            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                string temp = str.Substring(i, sub.Length);

                if (temp == sub)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Occurrences: " + count);
    }
}
