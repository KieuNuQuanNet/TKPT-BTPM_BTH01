using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_State
{
    public class HasCoinState : State
    {
        public HasCoinState(VendingMachine machine) : base(machine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("❌ Already have a coin.");
        }

        public override void SelectProduct()
        {
            Console.WriteLine("✅ Product selected.");
            machine.State = new DispensingState(machine);
            machine.Dispense();
        }
    }
}
