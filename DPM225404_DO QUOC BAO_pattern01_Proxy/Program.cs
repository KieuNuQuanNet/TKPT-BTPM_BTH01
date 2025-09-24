using DPM225404_DO_QUOC_BAO_pattern01_Proxy;
using System;

    public class Program
    {
        public static void Main(string[] args)
        {
        // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
