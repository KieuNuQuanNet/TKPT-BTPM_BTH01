using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real01_Facade
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Kiểm tra ngân hàng cho " + c.Name);
            return true;
        }
    }
    public class Customer
    {
        private string name;
        // Constructor
        public Customer(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }

}
