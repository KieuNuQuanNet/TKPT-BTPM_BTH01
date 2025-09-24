using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_Real01_Iterator
{
    public class Iterator : IAbstractIterator
    {
        ItemCollection collection;
        int current = 0;
        int step = 1;

        public Iterator(ItemCollection collection)
        {
            this.collection = collection;
        }

        public Item First()
        {
            current = 0;
            return collection[current];
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
                return collection[current];
            else
                return null;
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public Item CurrentItem
        {
            get { return collection[current]; }
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
