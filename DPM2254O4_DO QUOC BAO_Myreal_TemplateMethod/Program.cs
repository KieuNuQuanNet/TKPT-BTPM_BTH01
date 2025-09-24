using DPM2254O4_DO_QUOC_BAO_Myreal_TemplateMethod;
using System;
using System.Collections.Generic;

namespace Template.RealWorld
{
    /// <summary>
    /// Template Design Pattern - Example with Employees & Customers
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            DataAccessor employees = new Employees();
            employees.Run(4);

            DataAccessor customers = new Customers();
            customers.Run(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}