using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM2254O4_DO_QUOC_BAO_Myreal_TemplateMethod
{
    public class Employees : DataAccessor
    {
        private List<string> employees;

        public override void Connect()
        {
            employees = new List<string>();
        }

        public override void Select()
        {
            employees.Add("Alice");
            employees.Add("Bob");
            employees.Add("Charlie");
            employees.Add("Diana");
            employees.Add("Ethan");
        }

        public override void Process(int top)
        {
            Console.WriteLine("Employees ---- ");

            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(employees[i]);
            }

            Console.WriteLine();
        }

        public override void Disconnect()
        {
            employees.Clear();
        }
    }
    public class Customers : DataAccessor
    {
        private List<string> customers;

        public override void Connect()
        {
            customers = new List<string>();
        }

        public override void Select()
        {
            customers.Add("Tom");
            customers.Add("Jerry");
            customers.Add("Mickey");
            customers.Add("Donald");
            customers.Add("Goofy");
        }

        public override void Process(int top)
        {
            Console.WriteLine("Customers ---- ");

            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(customers[i]);
            }

            Console.WriteLine();
        }

        public override void Disconnect()
        {
            customers.Clear();
        }
    }
}
