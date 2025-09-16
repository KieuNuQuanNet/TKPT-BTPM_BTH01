namespace DPM225404_DO_QUOC_BAO_MYREAL01_Prototype
{
    using DPM225404_DO_QUOC_BAO_REAL01_Prototype;
    using System;
    using System.Collections.Generic;
    namespace Prototype.RealWorld
    {
        /// <summary>
        /// Prototype Design Pattern
        /// </summary>
        public class Program
        {
            public static void Main(string[] args)
            {
                ColorManager colormanager = new ColorManager();
                // Initialize with standard colors
                colormanager["blue"] = new Color(0, 0, 255);
                
                colormanager["green"] = new Color(0, 255, 0);
                colormanager["red"] = new Color(255, 0, 0);
                // User adds personalized colors
                
                
                colormanager["flame"] = new Color(211, 34, 20);
                colormanager["angry"] = new Color(255, 54, 0);
                colormanager["peace"] = new Color(128, 211, 128);
                // User clones selected colors
                
                Color color2 = colormanager["peace"].Clone() as Color;
                Color color1 = colormanager["red"].Clone() as Color;
                Color color3 = colormanager["flame"].Clone() as Color;
                // Wait for user
                Console.ReadKey();
            }
        }
    }
}
