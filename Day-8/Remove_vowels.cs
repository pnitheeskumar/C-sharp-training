
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
            char ch = char.ToLower(str[i]);

            if (ch != 'a' && ch != 'e' && ch != 'i'
                && ch != 'o' && ch != 'u')
            {
                result = result + str[i];
            }
        }

        Console.WriteLine("Output: " + result);
    }
}
