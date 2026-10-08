using System;
public class calculator {
    public static void Main(string[] args)
    {
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