using DPM225404_DO_QUOC_BAO_pattern_State;
using System;

namespace State.Structural
{
    /// <summary>
    /// State Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();
        }
    }
}