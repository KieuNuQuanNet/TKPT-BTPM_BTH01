using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_State
{
    public class SoldOutState : State
    {
        public SoldOutState(VendingMachine machine) : base(machine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("❌ Machine is sold out.");
        }

        public override void SelectProduct()
        {
            Console.WriteLine("❌ Machine is sold out.");
        }
    }
}
