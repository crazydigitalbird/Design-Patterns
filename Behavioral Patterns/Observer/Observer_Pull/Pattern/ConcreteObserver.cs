namespace Observer_Pull.Pattern
{
    class ConcreteObserver : Observer
    {
        private string observerState;

        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            observerState = subject.State;
        }
    }
}
