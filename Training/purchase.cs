public class purchase {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter ur purchase amoount: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        if (a >= 5000)
        {
            Console.WriteLine("u have got 5 percentage discount on ur purchase: ");
            double New_price= a *0.05 + a;
            double Gst_with_discount = (New_price *0.18 +New_price);
            Console.WriteLine("ur total price is "+ Gst_with_discount);
        }
    // }} nested if ...apti must be 70 abobe ...first u have to clear aptitude
    // technical must be 80 abouve
    // hr must be 80 abouve
    // minimum 230 marks to be eligible for placement 
    // 280-300 means 25k
    // 250-280 20k
    // below 250 15k
    }}