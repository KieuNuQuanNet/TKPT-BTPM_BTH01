using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_REAL01_Builder
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }
        public override void BuildFrame()
        {
            vehicle["Khung"] = "Car Frame";
        }
        public override void BuildEngine()
        {
            vehicle["DongCo"] = "2500 cc";
        }
        public override void BuildWheels()
        {
            vehicle["Banh"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["Cua"] = "4";
        }
    }

}
