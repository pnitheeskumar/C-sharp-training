 
 using System;
public class Work {
    public static void Main(string[] args)
    {
 
 
 Console.WriteLine("Enter ur Salary: ");
        int salary = Convert.ToInt32(Console.ReadLine());
        int Total_No_Of_working_Days = 26;
        int Work_Experierice = Convert.ToInt32(Console.ReadLine());
        if(Work_Experierice <= 2)
        {
            double Salary_with_increment = salary * 0.01 +salary;
            Console.WriteLine("ur total salary is "+ Salary_with_increment);
        }
        else if(Work_Experierice>2 && Work_Experierice<=3)
        {
        double salary_2_to_3_years = salary * 0.05 + salary;
        Console.WriteLine("ur total salary is "+ salary_2_to_3_years);
            
        }
        else if(Work_Experierice>3 && Work_Experierice<=5)
        {
            double salary_3_to_5_years = salary * 0.10 + salary;
            Console.WriteLine("ur total salary is "+ salary_3_to_5_years);
        }
    }}
