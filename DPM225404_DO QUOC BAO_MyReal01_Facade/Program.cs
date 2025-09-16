
using DPM225404_DO_QUOC_BAO_Real01_Facade;
using System;
namespace Facade.RealWorld
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade
            Mortgage mortgage = new Mortgage();
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
                    "  cho " + (eligible ? "tín dụng " : "Rejected"));
            // Wait for user
            Console.ReadKey();
        }
    }
}