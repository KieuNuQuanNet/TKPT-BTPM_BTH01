using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_State
{
    public class DispensingState : State
    {
        public DispensingState(VendingMachine machine) : base(machine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("❌ Please wait, dispensing product.");
        }

        public override void SelectProduct()
        {
            Console.WriteLine("❌ Already dispensing.");
        }
    }
}
