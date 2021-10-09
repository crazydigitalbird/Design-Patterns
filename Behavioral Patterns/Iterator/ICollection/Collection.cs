using System;
using System.Collections;

namespace Collection
{
    class Collection : ICollection
    {
        private readonly object[] elements = { 1, 2, 3, 4, 5 };

        private readonly object syncRoot = new object();

        public int Count
        {
            get
            {
                return elements.Length;
            }
        }

        public object SyncRoot
        {
            get
            {
                return syncRoot;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return true;
            }
        }

        public void CopyTo(Array array, int index)
        {
            elements.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
