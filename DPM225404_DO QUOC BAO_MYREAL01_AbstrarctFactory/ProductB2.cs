using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real_AbstractFactory
{
    class Wolf : Carnivore
    {
        public override void an(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
              " an " + h.GetType().Name);
        }
    }
}
