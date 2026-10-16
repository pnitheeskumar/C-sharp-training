using System;

public class area_of_triangle {
    public static void Main(string[] args) {
        Console.WriteLine("Enter the A and B values:");
         int a = Convert.ToInt32(Console.ReadLine());
         int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of triangle");
        double area = 0.5 * a * b;
        Console.WriteLine(area);}}