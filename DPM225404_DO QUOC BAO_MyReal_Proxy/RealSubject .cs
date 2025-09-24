using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal_Proxy
{
    public class RealDocument : IDocument
    {
        private string _fileName;

        public RealDocument(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk(); // giả sử tốn nhiều thời gian
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading file: {_fileName} ...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying: {_fileName}");
        }
    }
}
