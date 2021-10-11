namespace Momento.Pattern
{
    class Originator
    {
        public string State { get; set; }

        public Momento CreateMomento()
        {
            
            Momento momento = new Momento(State);
            return momento;
        }

        public void SetMomento(Momento momento)
        {
            State = momento.State;
        }
    }
}
