using DPM225404_DO_QUOC_BAO_Real01_Command;
using System;
using System.Collections.Generic;
namespace Command.RealWorld
{
    /// <summary>
    /// Command Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create user and let her compute
            User user = new User();
            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            // Undo 4 commands
            user.Undo(4);
            // Redo 3 commands
            user.Redo(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}