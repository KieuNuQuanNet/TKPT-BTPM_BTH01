using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_REAL01_Builder
{
    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();
        // Constructor
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }
        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Khung : {0}", _parts["Khung"]);
            Console.WriteLine(" DongCo : {0}", _parts["DongCo"]);
            Console.WriteLine(" #Banh: {0}", _parts["Banh"]);
            Console.WriteLine(" #Cua : {0}", _parts["Cua"]);
        }
    }
}
