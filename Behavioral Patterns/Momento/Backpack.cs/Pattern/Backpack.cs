namespace Backpack.Pattern
{
    class Backpack
    {
        public string Contents { get; private set; }

        public Backpack(string contents)
        {
            this.Contents = contents;
        }
    }
}
