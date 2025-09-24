using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Myreal01_Mediator
{
    public class Aircraft
    {
        protected string name;
        protected ControlTower tower;

        public Aircraft(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public ControlTower Tower
        {
            get { return tower; }
            set { tower = value; }
        }

        public void Send(string to, string message)
        {
            tower.Send(name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: '{message}'");
        }
    }
}
