using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_pattern01_Proxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            // Use 'lazy initialization'
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
