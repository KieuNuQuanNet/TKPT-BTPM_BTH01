using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal01_Mediator
{
    public class ControlTower : AbstractTower
    {
        private Dictionary<string, Aircraft> aircrafts = new Dictionary<string, Aircraft>();

        public override void Register(Aircraft aircraft)
        {
            if (!aircrafts.ContainsKey(aircraft.Name))
            {
                aircrafts[aircraft.Name] = aircraft;
                aircraft.Tower = this;
            }
        }

        public override void Send(string from, string to, string message)
        {
            if (aircrafts.ContainsKey(to))
            {
                Aircraft receiver = aircrafts[to];
                receiver.Receive(from, message);
            }
        }
    }
    public class PassengerAircraft : Aircraft
    {
        public PassengerAircraft(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("✈️ Passenger Aircraft receives -> ");
            base.Receive(from, message);
        }
    }
    public class MilitaryAircraft : Aircraft
    {
        public MilitaryAircraft(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("🛩️ Military Aircraft receives -> ");
            base.Receive(from, message);
        }
    }
}
