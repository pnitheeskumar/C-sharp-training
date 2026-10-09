
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select Ward: 1.General 2.Private 3.ICU");
        int ward = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of days:");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter patient age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (ward < 1 || ward > 3 || days <= 0 || age < 0)
        {
            Console.WriteLine("Invalid details");
            return;
        }

        int roomCharge = 0;

        switch (ward)
        {
            case 1:
                roomCharge = 500;
                break;
            case 2:
                roomCharge = 2000;
                break;
            case 3:
                roomCharge = 5000;
                break;
        }

        double consultation = 800;
        double total = consultation + (roomCharge * days);

        if (age >= 60)
            total = total - (total * 0.05);

        Console.WriteLine("Consultation Charges: " + consultation);
        Console.WriteLine("Room Charges: " + (roomCharge * days));
        Console.WriteLine("Insurance: Not Applicable");
        Console.WriteLine("Medicine and Lab Charges: Not Applicable");
        Console.WriteLine("Final Amount Payable: " + total);
    }
}