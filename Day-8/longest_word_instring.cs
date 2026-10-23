
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string str = Console.ReadLine();

        string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string longest = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }

        Console.WriteLine("Longest word: " + longest);
    }
}
