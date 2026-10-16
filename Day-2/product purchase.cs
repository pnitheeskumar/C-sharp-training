using System;

public class HelloWorld {
    public static void Main(string[] args) {
        
        Console.WriteLine("Product Name:");
        String ProductName = Console.ReadLine();
        Console.WriteLine("quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("price of single product:");
        int price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Total price:");
        int total = price * quantity;
        Console.WriteLine(ProductName +" "+ quantity +" "+ total);
        double total_with_gst = 0.12 * total + total;
        Console.WriteLine(total_with_gst);
    }}