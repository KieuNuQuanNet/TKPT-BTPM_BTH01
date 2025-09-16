namespace DPM225404_DO_QUOC_BAO_pattren01_singleton
{
    using System;
    namespace Singleton.Structural
    {
        /// <summary>
        /// Singleton Design Pattern
        /// </summary>
        public class Program
        {
            public static void Main(string[] args)
            {
                // Constructor is protected -- cannot use new
                Siingleton s1 = Siingleton.Instance();
                Siingleton s2 = Siingleton.Instance();
                // Test for same instance
                if (s1 == s2)
                {
                    Console.WriteLine("Objects are the same instance");
                }
                // Wait for user
                Console.ReadKey();
            }
        }
    }
}
