using DPM225404_DO_QUOC_BAO_Real_TemplateMethod;
using System;
using System.Collections.Generic;
namespace Template.RealWorld
{
    /// <summary>
    /// Template Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}