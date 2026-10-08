using System;
public class quadrant {
    public static void Main(string[] args)
    {
                    Console.WriteLine("Enter the x and y values:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("First quaadrant");
        }
        else if(x<0 && y>0)
        {
            Console.WriteLine("Second Quadrant");
        }
        else if(x<0 && y < 0)
        {
            Console.WriteLine("Third Quadrant");
        }
        else if(x>0 && y < 0)
        {
            Console.WriteLine("Fourth Quadrant");
        }}}