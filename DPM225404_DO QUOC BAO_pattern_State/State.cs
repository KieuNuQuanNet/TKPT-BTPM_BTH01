using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_pattern_State
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
