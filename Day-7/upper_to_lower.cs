
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
            char ch = str[i];

            if (ch >= 'A' && ch <= 'Z')
            {
                result += char.ToLower(ch);
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                result += char.ToUpper(ch);
            }
            else
            {
                result += ch;
            }
        }

        Console.WriteLine("Output: " + result);
    }
}
