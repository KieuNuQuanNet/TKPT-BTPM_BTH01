using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal_Strategy
{
    public abstract class TaxStrategy
    {
        public abstract void Calculate(double amount);
    }
}
