using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreak01_Obsetver
{
    public class WeatherStation : Subject
    {
        private string name;
        private double temperature;

        public WeatherStation(string name, double temperature)
        {
            this.name = name;
            this.temperature = temperature;
        }

        public string Name => name;

        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature != value)
                {
                    temperature = value;
                    Notify();
                }
            }
        }
    }
}
