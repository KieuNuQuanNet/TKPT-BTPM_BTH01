using DPM225404_DO_QUOC_BAO_Real01_Observer;
using System;
using System.Collections.Generic;
namespace Observer.RealWorld
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));
            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            // Wait for user
            Console.ReadKey();
        }
    }
}