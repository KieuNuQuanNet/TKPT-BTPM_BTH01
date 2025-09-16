using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_pattren01_singleton
{
    public class Siingleton
    {
        static Siingleton instance;
        // Constructor is 'protected'
        protected Siingleton()
        {
        }
        public static Siingleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new Siingleton();
            }
            return instance;
        }
    }
}
