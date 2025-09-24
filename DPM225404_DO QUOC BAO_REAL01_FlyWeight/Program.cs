using DPM225404_DO_QUOC_BAO_REAL01_FlyWeight;
using System;
using System.Collections.Generic;
namespace Flyweight.RealWorld
{
    /// <summary>
    /// Flyweight Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();
            CharacterFactory factory = new CharacterFactory();
            // extrinsic state
            int pointSize = 10;
            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}