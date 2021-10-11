namespace Backpack.Pattern
{
    class Man
    {
        public string Things { get; set; }

        public Backpack Undress()
        {
            return new Backpack(Things);
        }

        public void Dress(Backpack backpack)
        {
            this.Things = backpack.Contents;
        }
    }
}
