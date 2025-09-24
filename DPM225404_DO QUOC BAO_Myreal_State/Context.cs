using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_State
{
    public class VendingMachine
    {
        private State state;
        private int stock;

        public VendingMachine(int stock)
        {
            this.stock = stock;
            this.state = new NoCoinState(this);
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void InsertCoin()
        {
            state.InsertCoin();
        }

        public void SelectProduct()
        {
            state.SelectProduct();
        }

        public void Dispense()
        {
            if (stock > 0)
            {
                stock--;
                Console.WriteLine("🛒 Dispensing product... Stock left: " + stock);

                if (stock > 0)
                {
                    State = new NoCoinState(this);
                }
                else
                {
                    Console.WriteLine("⚠️ Machine is now sold out!");
                    State = new SoldOutState(this);
                }
            }
            else
            {
                Console.WriteLine("❌ No stock available.");
                State = new SoldOutState(this);
            }
        }
    }
}
