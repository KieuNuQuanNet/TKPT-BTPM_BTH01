using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real01_Iterator
{
    public class ItemCollection : IAbstractCollection
    {
        private List<Item> items = new List<Item>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        // Indexer
        public Item this[int index]
        {
            get
            {
                if (index < items.Count)
                    return items[index];
                return null;
            }
            set
            {
                if (index < items.Count)
                    items[index] = value;
                else
                    items.Add(value);
            }
        }
    }
}
