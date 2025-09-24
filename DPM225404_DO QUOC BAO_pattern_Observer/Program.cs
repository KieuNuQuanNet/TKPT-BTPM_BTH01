using DPM225404_DO_QUOC_BAO_pattern_Observer;
using System;
using System.Collections.Generic;
namespace Observer.Structural
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            // Wait for user
            Console.ReadKey();
        }
    }
}