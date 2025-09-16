using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real01_Facade
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Kiểm tra ngân hàng cho " + c.Name);
            return true;
        }
    }
}
