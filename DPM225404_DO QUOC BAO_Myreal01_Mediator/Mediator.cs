using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal01_Mediator
{
    public abstract class AbstractTower
    {
        public abstract void Register(Aircraft aircraft);
        public abstract void Send(string from, string to, string message);
    }
}
