namespace DPM225404_DO_QUOC_BAO_MYREAL01_Singleton
{
    using DPM225404_DO_QUOC_BAO_REAL01_Singleton;
    using System;
    using System.Collections.Generic;
    namespace Singleton.RealWorld
    {
        /// <summary>
        /// Singleton Design Pattern
        /// </summary>
        public class Program
        {
            public static void Main(string[] args)
            {
                LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
                LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
                LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
                LoadBalancer b4 = LoadBalancer.GetLoadBalancer();
                // Same instance?
                if (b1 == b2 && b2 == b3 && b3 == b4)
                {
                    Console.WriteLine("Same instance\n");
                }
                // Load balance 15 server requests
                LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
                for (int i = 0; i < 15; i++)
                {
                    string MayChu = balancer.MayChu;
                    Console.WriteLine("yeu cau giao den: " + MayChu);
                }
                // Wait for user
                Console.ReadKey();
            }
        }

    }
}
