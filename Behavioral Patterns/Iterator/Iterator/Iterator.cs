namespace Iterator
{
    abstract class Iterator
    {
        public abstract object First();

        public abstract object Next();

        public abstract bool isDone();

        public abstract object CurrentItem();
    }
}
