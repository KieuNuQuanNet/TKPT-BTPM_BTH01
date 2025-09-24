using DPM225404_DO_QUOC_BAO_Myreal_State;
using System;

namespace State.RealWorld
{
    /// <summary>
    /// State Design Pattern Example - Vending Machine
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine(2);

            machine.InsertCoin();
            machine.SelectProduct();

            machine.InsertCoin();
            machine.SelectProduct();

            machine.InsertCoin(); // hết hàng
            machine.SelectProduct();

            Console.ReadKey();
        }
    }
}