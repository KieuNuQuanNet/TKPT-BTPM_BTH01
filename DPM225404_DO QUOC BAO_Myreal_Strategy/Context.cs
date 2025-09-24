using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_Strategy
{
    public class Invoice
    {
        private TaxStrategy _taxStrategy;
        public string InvoiceNumber { get; }
        public double Amount { get; }

        public Invoice(string number, double amount)
        {
            InvoiceNumber = number;
            Amount = amount;
        }

        public void SetTaxStrategy(TaxStrategy taxStrategy)
        {
            _taxStrategy = taxStrategy;
        }

        public void CalculateTax()
        {
            Console.WriteLine($"\nInvoice: {InvoiceNumber}");
            _taxStrategy.Calculate(Amount);
        }
    }
}
