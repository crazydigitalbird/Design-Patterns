namespace Father
{
    class Father
    {
        public State State { get; set; }

        public Father()
        {
            this.State = new NeutralState();
        }

        public void FindeOut(Mark mark)
        {
            this.State.HandleMark(this, mark);
        }
    }
}
