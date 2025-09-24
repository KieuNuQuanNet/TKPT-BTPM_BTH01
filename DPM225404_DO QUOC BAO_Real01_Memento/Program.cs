using System;

namespace Memento.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            s.RestoreMemento(m.Memento);

            Console.ReadKey();
        }
    }

    public class SalesProspect
    {
        string name;
        string phone;
        double budget;

        public string Name
        {
            get { return name; }
            set { name = value; Console.WriteLine("Name:   " + name); }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; Console.WriteLine("Phone:  " + phone); }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; Console.WriteLine("Budget: " + budget); }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(name, phone, budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }

    public class Memento
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public Memento(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }
    }

    public class ProspectMemory
    {
        public Memento Memento { get; set; }
    }
}
