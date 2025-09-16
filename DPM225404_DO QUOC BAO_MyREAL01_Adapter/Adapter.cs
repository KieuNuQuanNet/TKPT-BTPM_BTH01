using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_REAL01_Adapter
{
    public class RichCompound : Compound
    {
        private string chemical;
        private ChemicalDatabank bank;
        // Constructor
        public RichCompound(string chemical)
        {
            this.chemical = chemical;
        }
        public override void Display()
        {
            // The Adaptee
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);
            Console.WriteLine("\nCompound: {0} ------ ", chemical);
            Console.WriteLine(" Cong Thuc: {0}", molecularFormula);
            Console.WriteLine(" Khoi Luong : {0}", molecularWeight);
            Console.WriteLine(" Nhiet Do Nong Chay: {0}", meltingPoint);
            Console.WriteLine(" Nhiet Do Soi: {0}", boilingPoint);
        }
    }
}
