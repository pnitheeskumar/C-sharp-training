using System;

public class HelloWorld {
    public static void Main(string[] args) {
         //area of circle
        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToInt32(Console.ReadLine());
        double pi = 3.14;
        double area_of_circle = pi * radius*radius;
        Console.WriteLine("area of circle is:"+" "+ area_of_circle);
        double perimeter_of_circle = 2*pi*radius;
        Console.WriteLine("perimeter of circle is:" +" "+perimeter_of_circle);}}
        