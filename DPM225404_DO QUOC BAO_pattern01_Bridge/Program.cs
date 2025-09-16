using DPM225404_DO_QUOC_BAO_pattern01_Bridge;
using System;
namespace Bridge.Structural
{
    /// <summary>
    /// Bridge Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            // Wait for user
            Console.ReadKey();
        }
    }
}