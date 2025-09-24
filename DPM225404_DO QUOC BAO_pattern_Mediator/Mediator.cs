using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_pattern_Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string message,
            Colleague colleague);
    }
}
