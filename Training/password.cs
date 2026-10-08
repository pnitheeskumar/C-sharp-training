using System;
public class Password
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the password:");
        Console.WriteLine("Username: ");
        String username = Console.ReadLine();
        String password = Console.ReadLine();
        if (password == "nithees@123" && username == "nithees")
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            Console.WriteLine("Password is invalid");
        }
    }
}