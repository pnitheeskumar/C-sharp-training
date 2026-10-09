
using System;

public class Loop
{
    public static void Main(string[] args)
    {
        for (int i = 100; i <= 150; i++)
        {
            if (i % 9 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}








// using System;

// public class equations {
//     public static void Main(string[] args) {
//         Console.WriteLine("Enter the A and B values:");
//          int a = Convert.ToInt32(Console.ReadLine());
//          int b = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Sum is:");
//         int c = a+b;
//         Console.WriteLine (c);
//         Console.WriteLine("Enter the Two Name");
//         String name1 = Console.ReadLine();
//         String name2 = Console.ReadLine();
//         Console.WriteLine(name1 +" "+ name2);
//         Console.WriteLine("Equation for (a+b) whole square:");
//         int a_square= a*a;
//         int b_square = b*b;
//         int multi = 2*a*b;
//         int Wholesquare = a_square+ b_square+ multi;
//         Console.WriteLine(Wholesquare);}}