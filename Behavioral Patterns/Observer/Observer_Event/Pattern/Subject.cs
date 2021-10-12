namespace Observer_Event.Pattern
{
    abstract class Subject
    {
        protected Observer observers;

        public event Observer Event
        {
            add
            {
                observers += value;
            }

            remove
            {
                observers -= value;
            }
        }

        public abstract string State { get; set; }

        public abstract void Notify();
    }
}
