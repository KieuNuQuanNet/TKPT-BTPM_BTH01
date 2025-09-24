using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal01_Command
{
    public class RemoteControl
    {
        private List<Command> history = new List<Command>();
        private int current = 0;

        public void ExecuteCommand(Command command)
        {
            command.Execute();
            history.Add(command);
            current++;
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} steps ----", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command cmd = history[--current];
                    cmd.UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} steps ----", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current < history.Count)
                {
                    Command cmd = history[current++];
                    cmd.Execute();
                }
            }
        }
    }
}
