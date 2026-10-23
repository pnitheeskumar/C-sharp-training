
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                if (i == 0 || !char.IsDigit(str[i - 1]))
                {
                    result = result + "*";
                }
            }
            else
            {
                result = result + str[i];
            }
        }

        Console.WriteLine("Output: " + result);
    }
}
