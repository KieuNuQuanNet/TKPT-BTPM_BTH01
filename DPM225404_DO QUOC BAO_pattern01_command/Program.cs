using DPM225404_DO_QUOC_BAO_pattern01_command;
using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create receiver, command, and invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            // Wait for user
            Console.ReadKey();
        }
    }
