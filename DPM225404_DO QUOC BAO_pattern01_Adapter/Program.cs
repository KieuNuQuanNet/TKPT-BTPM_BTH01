namespace DPM225404_DO_QUOC_BAO_pattern01_Adapter
{
    using System;
    namespace Adapter.Structural
    {
        /// <summary>
        /// Adapter Design Pattern
        /// </summary>
        public class Program
        {
            public static void Main(string[] args)
            {
                // Create adapter and place a request
                Target target = new Aadapter();
                target.Request();
                // Wait for user
                Console.ReadKey();
            }
        }
    }
}
