using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_State
{
    public abstract class State
    {
        protected VendingMachine machine;

        public State(VendingMachine machine)
        {
            this.machine = machine;
        }

        public abstract void InsertCoin();
        public abstract void SelectProduct();
    }
}
