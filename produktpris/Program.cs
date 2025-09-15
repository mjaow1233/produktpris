using System.Security.Cryptography;

namespace produktpris
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
        Console.WriteLine("prisräknare");
        Console.WriteLine("Hur många äpplen vill du köpa?");
            var totalproducts = int.Parse(Console.ReadLine());
        Console.WriteLine("Hur mycket vill du betala för varje äpple?");
            var price = int.Parse(Console.ReadLine());

        Console.WriteLine("Hur mycket skatt betalar du i procent?");
            var vat = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            if (vat <= 0)

            {
                Console.WriteLine("Momsen måste vara större än 0%");
                return;
            } else if (vat > 100)
            { 
                Console.WriteLine("Momsen kan inte vara mer än 100%"); 
            }




                CalculatePrice(totalproducts, price, vat);
    
        }
    private static void CalculatePrice(
        int totalproducts,
        int price,
        double vat)
    {
        var totalprice = totalproducts * price;
        var vatamount = totalprice * (vat / 100);
        var totaltotal = totalprice + vatamount;
        Console.WriteLine($"Exmoms är priset {totalprice} kr");
        Console.WriteLine($"Momskostnaden är {vatamount} kr");
        Console.WriteLine($"Priset med moms är {totaltotal} kr");  
           
        }

}
}
