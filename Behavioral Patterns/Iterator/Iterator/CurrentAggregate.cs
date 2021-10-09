using System.Collections;

namespace Iterator
{
    class CurrentAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();

        public override object this[int index]
        {
            get => items[index];
            set => items.Insert(index, value);
        }

        public override int Count => items.Count;

        public override Iterator CreateIterator()
        {
            return new CurrentIterator(this);
        }
    }
}
