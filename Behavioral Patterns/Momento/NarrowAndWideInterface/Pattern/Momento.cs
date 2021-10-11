namespace NarrowAndWideInterface.Pattern
{
    class Momento: IWideInterface
    {
        public string State { get; set; }

        public Momento(string state)
        {
            this.State = state;
        }
    }
}
