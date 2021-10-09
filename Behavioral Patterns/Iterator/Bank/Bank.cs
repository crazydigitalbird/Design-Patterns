using System.Collections.Generic;

namespace Bank
{
    class Bank : IEnumerable
    {
        private List<Banknote> banknotes = new List<Banknote>() {
            new Banknote(),
            new Banknote()
        };

        public Banknote this[int index]
        {
            get
            {
                return banknotes[index];
            }
            set
            {
                banknotes.Insert(index, value);
            }
        }

        public int Count
        {
            get
            {
                return banknotes.Count;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new Cashier(this);
        }
    }
}
