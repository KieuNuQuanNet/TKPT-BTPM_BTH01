using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal01_Command
{
    public class TurnOnCommand : Command
    {
        private TV _tv;
        public TurnOnCommand(TV tv) { _tv = tv; }
        public override void Execute() { _tv.TurnOn(); }
        public override void UnExecute() { _tv.TurnOff(); }
    }

    public class TurnOffCommand : Command
    {
        private TV _tv;
        public TurnOffCommand(TV tv) { _tv = tv; }
        public override void Execute() { _tv.TurnOff(); }
        public override void UnExecute() { _tv.TurnOn(); }
    }

    public class VolumeUpCommand : Command
    {
        private TV _tv;
        public VolumeUpCommand(TV tv) { _tv = tv; }
        public override void Execute() { _tv.VolumeUp(); }
        public override void UnExecute() { _tv.VolumeDown(); }
    }

    public class VolumeDownCommand : Command
    {
        private TV _tv;
        public VolumeDownCommand(TV tv) { _tv = tv; }
        public override void Execute() { _tv.VolumeDown(); }
        public override void UnExecute() { _tv.VolumeUp(); }
    }
}
