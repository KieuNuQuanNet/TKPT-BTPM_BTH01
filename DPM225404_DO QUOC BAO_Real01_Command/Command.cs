using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real01_Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

}
