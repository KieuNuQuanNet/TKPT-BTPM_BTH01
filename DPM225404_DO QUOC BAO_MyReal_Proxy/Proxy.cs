using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal_Proxy
{
    public class DocumentProxy : IDocument
    {
        private RealDocument _realDocument;
        private string _fileName;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realDocument == null)
            {
                _realDocument = new RealDocument(_fileName);
            }
            _realDocument.Display();
        }
    }
}
