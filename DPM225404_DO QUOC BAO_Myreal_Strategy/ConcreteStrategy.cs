using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_Strategy
{
    public class VatTax : TaxStrategy
    {
        public override void Calculate(double amount)
        {
            double tax = amount * 0.1; // 10% VAT
            Console.WriteLine($"[VAT Tax] Amount: {amount:C}, Tax = {tax:C}");
        }
    }
    public class ServiceTax : TaxStrategy
    {
        public override void Calculate(double amount)
        {
            double tax = amount * 0.05; // 5% Service Tax
            Console.WriteLine($"[Service Tax] Amount: {amount:C}, Tax = {tax:C}");
        }
    }
    public class NoTax : TaxStrategy
    {
        public override void Calculate(double amount)
        {
            Console.WriteLine($"[No Tax] Amount: {amount:C}, Tax = 0");
        }
    }
}
