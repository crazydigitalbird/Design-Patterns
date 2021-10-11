namespace Momento.Pattern
{
    class Momento
    {
        public string State
        {
            get;
            private set;
        }
        public Momento(string state)
        {
            this.State = state;
        }
    }
}
