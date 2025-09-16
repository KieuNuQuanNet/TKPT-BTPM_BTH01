using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_REAL01_Builder
{
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildFrame()
        {
            vehicle["Khung"] = "MotorCycle Frame";
        }
        public override void BuildEngine()
        {
            vehicle["DongCo"] = "500 cc";
        }
        public override void BuildWheels()
        {
            vehicle["Banh"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["Cua"] = "0";
        }
    }
}
