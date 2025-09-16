namespace DPM225404_DO_QUOC_BAO_pattern01_Facade
{
    using System;
    namespace Facade.Structural
    {
        /// <summary>
        /// Facade Design Pattern
        /// </summary>
        public class Program
        {
            public static void Main(string[] args)
            {
                Faacade facade = new Faacade();
                facade.MethodA();
                facade.MethodB();
                // Wait for user
                Console.ReadKey();
            }
        }
        /// <summary>
        /// The 'Subsystem ClassA' class
        /// </summary>
        public class SubSystemOne
        {
            public void MethodOne()
            {
                Console.WriteLine(" SubSystemOne Method");
            }
        }
    }
}
