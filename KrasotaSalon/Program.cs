using System;

namespace KrasotaSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer test = new Customer("test", "0123", new GoldenMembership());
            ServiceProduct haircutKusa = new HairCut("Kusa", 5, "kuso");
            ServiceProduct haircutSredna = new HairCut("Sredna", 6, "sredno");
            ServiceProduct haircutDulga = new HairCut("Dulga", 7, "dulgo");

            Visit newVisit = new Visit(test);
            newVisit.AddServiceProduct(haircutKusa);
            newVisit.AddServiceProduct(haircutSredna);
            newVisit.AddServiceProduct(haircutDulga);
            Console.WriteLine("Total price : " +newVisit.GetTotalPrice());
            newVisit.PrintInvoice();
        }
    }
}
