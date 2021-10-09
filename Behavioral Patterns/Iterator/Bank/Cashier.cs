namespace Bank
{
    class Cashier : IEnumerator
    {
        private Bank enumerable;
        private int count = -1;

        public Cashier(Bank enumerable)
        {
            this.enumerable = enumerable;
        }

        public bool MoveNext()
        {
            if (count < enumerable.Count - 1)
            {
                count++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            count = -1;
        }

        public object Current
        {
            get
            {
                return enumerable[count];
            }
        }

    }
}
