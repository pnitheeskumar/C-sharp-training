using System;
public class HelloWorld {
    public static void Main(string[] args)
    {
    //     Console.WriteLine("Enter ur purchase amoount: ");
    //     int a = Convert.ToInt32(Console.ReadLine());
    // //     if( a >= 90)
    // //     {
    // //         Console.WriteLine("Schorlarship is 100%");
    // //     }
    // //     else
    // //     {
    // //         Console.WriteLine("Schorlarship is 0%");
    // //     }
    //     if (a >= 5000)
    //     {
    //         Console.WriteLine("u have got 5 percentage discount on ur purchase: ");
    //         double New_price= a *0.05 + a;
    //         double Gst_with_discount = (New_price *0.18 +New_price);
    //         Console.WriteLine("ur total price is "+ Gst_with_discount);
    //     }

        //slary,noof working days,10 percern increment, 5 yeras work experience 
        // Console.WriteLine("Enter ur Salary: ");
        // int salary = Convert.ToInt32(Console.ReadLine());
        // int Total_No_Of_working_Days = 26;
        // int Work_Experierice = Convert.ToInt32(Console.ReadLine());
        // if(Work_Experierice <= 2)
        // {
        //     double Salary_with_increment = salary * 0.01 +salary;
        //     Console.WriteLine("ur total salary is "+ Salary_with_increment);
        // }
        // else if(Work_Experierice>2 && Work_Experierice<=3)
        // {
        // double salary_2_to_3_years = salary * 0.05 + salary;
        // Console.WriteLine("ur total salary is "+ salary_2_to_3_years);
            
        // }
        // else if(Work_Experierice>3 && Work_Experierice<=5)
        // {
        //     double salary_3_to_5_years = salary * 0.10 + salary;
        //     Console.WriteLine("ur total salary is "+ salary_3_to_5_years);
        // }

            //quadrant
        //     Console.WriteLine("Enter the x and y values:");
        //     int x = Convert.ToInt32(Console.ReadLine());
        //     int y = Convert.ToInt32(Console.ReadLine());
        // if (x > 0 && y > 0)
        // {
        //     Console.WriteLine("First quaadrant");
        // }
        // else if(x<0 && y>0)
        // {
        //     Console.WriteLine("Second Quadrant");
        // }
        // else if(x<0 && y < 0)
        // {
        //     Console.WriteLine("Third Quadrant");
        // }
        // else if(x>0 && y < 0)
        // {
        //     Console.WriteLine("Fourth Quadrant");
        // }




        // //percentage calculation
        // Console.WriteLine("Enter the Obtained marks and Total marks:");
        // int Obtained_marks = Convert.ToInt32(Console.ReadLine());
        // int Total_marks = Convert.ToInt32(Console.ReadLine());
        // int percentage = (Obtained_marks * 100) / Total_marks;
        // if (percentage >= 90)
        // {
        //     Console.WriteLine("S grade");
        // }
        // else if(percentage >=80 && percentage <90)
        // {
        //     Console.WriteLine("A grade");
        // }
        // else if(percentage >=70 && percentage <80)
        // {
        //     Console.WriteLine("B grade");
        // }
        // else if(percentage >=60 && percentage <70)
        // {
        //     Console.WriteLine("C grade");
        // }
        // else if(percentage >=50 && percentage <60)
        // {
        //     Console.WriteLine("D grade");
        // }
        // else
        // {
        //     Console.WriteLine("Fail");
        // }






    // calculator
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    char oper = Convert.ToChar(Console.ReadLine());
        switch(oper){
            case('+'):
                Console.WriteLine(a+b);
                break;
            case ('-'):
                Console.WriteLine(a-b);
                break;
            case ('*'):
                Console.WriteLine(a*b);
                break;
            case ('/'):
                Console.WriteLine(a/b);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
        }
}

    //2 years pto 1 percentage, 3 to 5 percen, 5 to 10 percentage




    
