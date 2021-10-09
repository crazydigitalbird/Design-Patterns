using System;
using System.Collections;

namespace List
{
    class List : IList
    {
        private ArrayList arrayList = new ArrayList();

        #region IList
        public object this[int index] { get => arrayList[index]; set => arrayList.Insert(index, value); }

        public bool IsFixedSize => arrayList.IsFixedSize;

        public bool IsReadOnly => arrayList.IsReadOnly;

        public int Add(object value)
        {
            return arrayList.Add(value);
        }

        public void Clear()
        {
            arrayList.Clear();
        }

        public bool Contains(object value)
        {
            return arrayList.Contains(value);
        }

        public int IndexOf(object value)
        {
            return arrayList.IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            arrayList.Insert(index, value);
        }

        public void Remove(object value)
        {
            arrayList.Remove(value);
        }

        public void RemoveAt(int index)
        {
            arrayList.RemoveAt(index);
        }
#endregion

        #region ICollection
        public void CopyTo(Array array, int index)
        {
            arrayList.CopyTo(array, index);
        }

        public int Count => arrayList.Count;

        public object SyncRoot => arrayList.SyncRoot;

        public bool IsSynchronized => arrayList.IsSynchronized;
        #endregion

        #region IEnumerable
        public IEnumerator GetEnumerator()
        {
            return arrayList.GetEnumerator();
        }
        #endregion
    }
}
