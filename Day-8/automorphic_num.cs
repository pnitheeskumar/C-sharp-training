
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long square = (long)num * num;
        long temp = num;
        long div = 1;

        do
        {
            div = div * 10;
            temp = temp / 10;
        }
        while (temp > 0);

        if (num >= 0 && square % div == num)
        {
            Console.WriteLine("Automorphic Number");
        }
        else
        {
            Console.WriteLine("Not Automorphic Number");
        }
    }
}
