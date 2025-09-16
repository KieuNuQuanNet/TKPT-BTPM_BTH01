namespace DPM225404_DO_QUOC_BAO_MYREAL01_Builder
{
    using DPM225404_DO_QUOC_BAO_REAL01_Builder;
    using System;
    using System.Collections.Generic;
    namespace DoFactory.GangOfFour.Builder.RealWorld
    {
        /// <summary>
        /// MainApp startup class for Real-World 
        /// Builder Design Pattern.
        /// </summary>
        public class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>
            public static void Main()
            {
                VehicleBuilder builder;
                // Create shop with vehicle builders
                Shop shop = new Shop();
                // Construct and display vehicles
                builder = new ScooterBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();
                builder = new CarBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();
                builder = new MotorCycleBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();
                // Wait for user
                Console.ReadKey();
            }
        }
    }
}
