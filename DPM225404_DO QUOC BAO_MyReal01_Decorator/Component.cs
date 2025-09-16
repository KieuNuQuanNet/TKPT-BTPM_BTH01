using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real01_Decorator
{
    public abstract class LibraryItem
    {
        private int numCopies;
        public int NumCopies
        {
            get { return numCopies; }
            set { numCopies = value; }
        }
        public abstract void Display();
    }
}
