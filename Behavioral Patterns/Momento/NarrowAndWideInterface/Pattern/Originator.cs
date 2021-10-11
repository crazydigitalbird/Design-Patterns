namespace NarrowAndWideInterface.Pattern
{
    class Originator
    {
        public string State { get; set; }

        public INarrowInterface GetMomento()
        {
            return new Momento(this.State);
        }

        public void SetMomento(IWideInterface momento)
        {
            this.State = momento.State;
        }
    }
}
