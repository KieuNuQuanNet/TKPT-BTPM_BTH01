using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real01_Mediator
{
    public abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
            string from, string to, string message);
    }
}
