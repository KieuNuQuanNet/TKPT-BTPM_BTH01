using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal01_Command
{
    public class TV
    {
        private bool isOn = false;
        private int volume = 10;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("TV is ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("TV is OFF");
        }

        public void VolumeUp()
        {
            if (isOn)
            {
                volume++;
                Console.WriteLine("Volume increased to {0}", volume);
            }
        }

        public void VolumeDown()
        {
            if (isOn)
            {
                volume--;
                Console.WriteLine("Volume decreased to {0}", volume);
            }
        }
    }
}
