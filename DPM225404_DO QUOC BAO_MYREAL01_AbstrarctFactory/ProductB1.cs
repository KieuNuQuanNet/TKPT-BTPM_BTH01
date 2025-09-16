using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real_AbstractFactory
{
    class Lion : Carnivore
    {
        public override void an(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
              " an " + h.GetType().Name);
        }
    }
}
