using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal01_chainofresp
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(SupportRequest request);
    }
}
