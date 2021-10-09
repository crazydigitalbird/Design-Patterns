namespace Iterator
{
    class CurrentIterator : Iterator
    {
        private Aggregate aggregate;
        private int current = 0;

        public CurrentIterator(Aggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool isDone()
        {
            if (current < aggregate.Count)
            {
                return false;
            }

            current = 0;
            return true;
        }

        public override object Next()
        {
            if (current++ < aggregate.Count - 1)
            {
                return aggregate[current];
            }
            else
            {
                return null;
            }
        }
    }
}
