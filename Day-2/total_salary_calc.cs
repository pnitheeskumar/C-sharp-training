using System;

public class HelloWorld {
    public static void Main(string[] args) {
         Console.WriteLine("enter ur salary:");
        int salary = Convert.ToInt32(Console.ReadLine());
        int total_working_days= 26;
        
        // int total_coming_days= Convert.ToInt32(Console.ReadLine());
        // int salary_of_1_day = 15000/26;
        // int total_salary = salary_of_1_day * total_coming_days;
        // double salary_incre= salary*0.10+ salary;
        // Console.WriteLine("So total salary of 10 days is :"+ total_salary);
        // Console.WriteLine("total increase:");
        // Console.WriteLine(salary_incre);
        double Esi = 0.03;
        double pf = 0.02;
        double deduction = Esi + pf;
        double deduction_of_salary = salary * deduction + salary;
        Console.WriteLine("total deduction after esi and pf" +" "+deduction_of_salary);}}