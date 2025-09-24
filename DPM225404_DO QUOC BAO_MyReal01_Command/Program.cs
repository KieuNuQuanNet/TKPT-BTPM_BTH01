using DPM225404_DO_QUOC_BAO_MyReal01_Command;
using System;
using System.Collections.Generic;

namespace Command.TVExample
{
    /// <summary>
    /// Command Pattern - TV Remote
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            TV tv = new TV();

            // Bấm các nút trên remote
            remote.ExecuteCommand(new TurnOnCommand(tv));
            remote.ExecuteCommand(new VolumeUpCommand(tv));
            remote.ExecuteCommand(new VolumeUpCommand(tv));
            remote.ExecuteCommand(new VolumeDownCommand(tv));
            remote.ExecuteCommand(new TurnOffCommand(tv));

            // Undo 3 thao tác
            remote.Undo(3);

            // Redo 2 thao tác
            remote.Redo(2);

            Console.ReadKey();
        }
    }
}