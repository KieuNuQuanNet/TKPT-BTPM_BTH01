using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_State
{
    public class NoCoinState : State
    {
        public NoCoinState(VendingMachine machine) : base(machine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("💰 Coin inserted.");
            machine.State = new HasCoinState(machine);
        }

        public override void SelectProduct()
        {
            Console.WriteLine("❌ Insert coin first.");
        }
    }
}
