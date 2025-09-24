using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreak01_Obsetver
{
    public interface IObserver
    {
        void Update(Subject subject);
    }
}
