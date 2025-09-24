using DPM225404_DO_QUOC_BAO_Myreal_Strategy;
using System;

namespace Strategy.RealWorld
{
    /// <summary>
    /// Strategy Design Pattern - RealWorld Example (Tax Calculation)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Invoice invoice = new Invoice("INV-1001", 2000);

            // Apply VAT Tax
            invoice.SetTaxStrategy(new VatTax());
            invoice.CalculateTax();

            // Apply Service Tax
            invoice.SetTaxStrategy(new ServiceTax());
            invoice.CalculateTax();

            // Apply No Tax
            invoice.SetTaxStrategy(new NoTax());
            invoice.CalculateTax();

            Console.ReadKey();
        }
    }
}