
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select Room Type: 1.Standard 2.Deluxe 3.Suite");
        int room = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of days:");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Customer Type: 1.Membership 2.Normal");
        int customer = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Food required? (yes/no)");
        string food = Console.ReadLine();

        if (days <= 0 || room < 1 || room > 3 ||
            customer < 1 || customer > 2 ||
            (food != "yes" && food != "no"))
        {
            Console.WriteLine("Invalid booking details");
            return;
        }

        int rate = 1000;

        switch (room)
        {
            case 1:
                rate = 1000;
                break;
            case 2:
                rate = 2000;
                break;
            case 3:
                rate = 3000;
                break;
        }

        double total = rate * days;

        if (food == "yes")
            total = total + (500 * days);

        if (customer == 1)
            total = total - (total * 0.05);

        double gst = total * 0.12;
        double bill = total + gst;

        Console.WriteLine("Room Charges: " + (rate * days));
        Console.WriteLine("GST: " + gst);
        Console.WriteLine("Final Bill: " + bill);
    }
}