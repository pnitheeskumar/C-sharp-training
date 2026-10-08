using System;
public class grade {
    public static void Main(string[] args)
    {
        //percentage calculation
        Console.WriteLine("Enter the Obtained marks and Total marks:");
        int Obtained_marks = Convert.ToInt32(Console.ReadLine());
        int Total_marks = Convert.ToInt32(Console.ReadLine());
        int percentage = (Obtained_marks * 100) / Total_marks;
        if (percentage >= 90)
        {
            Console.WriteLine("S grade");
        }
        else if(percentage >=80 && percentage <90)
        {
            Console.WriteLine("A grade");
        }
        else if(percentage >=70 && percentage <80)
        {
            Console.WriteLine("B grade");
        }
        else if(percentage >=60 && percentage <70)
        {
            Console.WriteLine("C grade");
        }
        else if(percentage >=50 && percentage <60)
        {
            Console.WriteLine("D grade");
        }
        else
        {
            Console.WriteLine("Fail");
        }

    }}